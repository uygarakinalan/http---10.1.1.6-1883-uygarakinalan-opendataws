using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opendataws.entity.Entities;

namespace opendataws.data.Context
{
    public class EnvironmentContext : DbContext
    {

        public DbSet<EnvironmentData> EnvironmentData
        {
            get; set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.1.1.27;Database=Environment;User Id=sa;Password=[msm5141];");
        }
    }
}


