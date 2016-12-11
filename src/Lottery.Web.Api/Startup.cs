namespace Lottery.Web.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore;
    using Lottery.Service.Abstractions;
    using Lottery.Service.Implementations;
    using Lottery.Prediction;
    using Lottery.Prediction.Implementations;
    using Lottery.Repository.EntityFramework;
    using Lottery.Entity.Entities;
    using Lottery.Prediction;
    using Lottery.Prediction.Implementations;

    
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddTransient<IPredictionService, PredictionService>();
            services.AddTransient<IPrediction, SimplePredictionAlgorithm>();
            services.AddDbContext<LotteryDbContext>(opt => opt.UseInMemoryDatabase());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            var context = app.ApplicationServices.GetService<LotteryDbContext>();

            this.Seed(context);

            app.UseMvcWithDefaultRoute();
        }

        private void Seed(LotteryDbContext dbContext) 
        {
            dbContext.LotteryResults.Add(new SeventhPrizeEntity() 
            {
                Result = 20,
                CreatedDate = DateTime.Now
            });

            dbContext.SaveChanges();
        }
    }
}
