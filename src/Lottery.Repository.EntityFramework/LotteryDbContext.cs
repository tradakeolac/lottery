using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lottery.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Extensions;

namespace Lottery.Repository.EntityFramework
{
    public class LotteryDbContext : DbContext
    {
        public LotteryDbContext(DbContextOptions<LotteryDbContext> options) 
        : base(options)
        {
        }

        public DbSet<LotteryResultEntity> LotteryResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LotteryResultEntity>()
                        .HasDiscriminator<int>("type")
                        .HasValue<SeventhPrizeEntity>(7);
        }
    }
}
