using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lottery.Web.Api.Controllers
{    
    public class LottoController : BaseController
    {
        [Route("/api/lottery/all")]
        public IActionResult GetAll() 
        {
            var a = 1;
            return View();
        }
    }
}
