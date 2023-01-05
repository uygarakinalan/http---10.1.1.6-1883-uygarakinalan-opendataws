using Microsoft.EntityFrameworkCore;
using opendataws.entity.Entities;
using opendataws.entity.Entities.Views;

namespace opendataws.entity.Context
{
    public class TestContext : DbContext
    {

        public DbSet<TypeView> TypeView
        {
            get; set;
        }

        public DbSet<Test> Test
        {
            get; set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.1.1.27;Database=tmp_ua2;User Id=sa;Password=[msm5141];");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Query<TypeView>().ToView("AuthorArticleCount");

            modelBuilder.Entity<TypeView>(entity =>
            {
                //entity.HasKey(e => e.Id);
                //entity.ToTable("TypeView");
                //entity.Property(e => e.Name).HasMaxLength(50);
                entity.HasNoKey();
                entity.ToView("TypeView");

            });

        }*/
    }
}