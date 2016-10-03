using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using HtmlAgilityPack;

namespace Lottery.Crawler
{
    public class MineralMiner : IFortuneHunter
    {
        public MineralMiner()
        {
        }

        public async Task<string> Mine(MinerConfiguration configuration)
        {
            using (var client = new HttpClient())
            using (var response = await client.GetAsync(configuration.Address))
            using (var content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(result);

                return result;
            
            }
        }
    }
}
