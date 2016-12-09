using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lottery.Service.Abstractions;

namespace Lottery.Web.Api.Controllers.Api
{    
    [Route("/api/lottery")]
    public class LotteryController : LotteryApiControllerBase
    {
        private readonly IPredictionService PredictionService;

        public LotteryController(IPredictionService predictionService)
        {
            this.PredictionService = predictionService;
        }

        [Route("all")]
        public IActionResult GetAll() 
        {

            return Json(2);
            return Json(this.PredictionService.Predict());
        }

        public IActionResult Like(int number)
        {
            return Json(this.PredictionService.Predict());
        }
    }
}
