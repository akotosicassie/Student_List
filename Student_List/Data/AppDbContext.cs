using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_List.Models;

namespace Student_List.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Student>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}
