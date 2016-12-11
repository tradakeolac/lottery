using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lottery.Service.Abstractions;
using Lottery.Repository.EntityFramework;
using Lottery.Entity.Entities;

namespace Lottery.Web.Api.Controllers.Api
{    
    [Route("/api/lottery")]
    public class LotteryController : LotteryApiControllerBase
    {
        private readonly IPredictionService PredictionService;
        private readonly LotteryDbContext DbContext;

        public LotteryController(IPredictionService predictionService, LotteryDbContext dbContext)
        {
            this.PredictionService = predictionService;
            this.DbContext = dbContext;
        }

        [Route("all")]
        public async Task<IActionResult> GetAll() 
        {
            var values = this.DbContext.LotteryResults.ToList();
            return Json(this.PredictionService.Predict());
        }

        public IActionResult Like(int number)
        {
            return Json(this.PredictionService.Predict());
        }
    }
}
