using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opendataws.entity;

namespace opendataws.data.Context
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users
        {
            get; set;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.1.1.27;Database=tmp_alo153;User Id=sa;Password=[msm5141];");
        }

    }
}