using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opendataws.entity.Entities.Views;

namespace opendataws.data.Context
{
    public class MezarlikContext : DbContext
    {
        public DbSet<OlumView> TestView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.1.1.27;Database=MEZARLIK;User Id=sa;Password=[msm5141];");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Query<TypeView>().ToView("AuthorArticleCount");

            modelBuilder.Entity<OlumView>(entity =>
            {
                //entity.HasKey(e => e.Id);
                //entity.ToTable("TypeView");
                //entity.Property(e => e.Name).HasMaxLength(50);
                entity.HasNoKey();
                entity.ToView("TestView");
            });

        }
    }
}