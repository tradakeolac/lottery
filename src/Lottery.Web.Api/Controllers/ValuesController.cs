using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lottery.Crawler;

namespace Lottery.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static IEnumerable<string> Values = new List<string>();
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var configuration = new MinerConfiguration
            {
                Address = "ketquaxoso.24h.com.vn/ngay-02-10-2016"
            };

            IFortuneHunter miner = new MineralMiner();
            miner.Mine(configuration);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
