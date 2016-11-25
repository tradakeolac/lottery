using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lottery.Infrastructure;
using Lottery.Repository;
using Lottery.Repository.EntityFramework;
using Lottery.Service;
using Lottery.Prediction;
using Lottery.Crawler;
using Microsoft.Extensions.DependencyInjection;

namespace Lottery.Web.Infrastructure
{
    public class Ioc
    {
        public static void Config(IServiceCollection serviceCollection) 
        {
            
        }
    }
}
