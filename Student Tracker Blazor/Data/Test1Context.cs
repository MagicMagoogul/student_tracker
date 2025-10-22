using Microsoft.EntityFrameworkCore;

namespace Student_Tracker_Blazor.Data
{
    public class Test1Context : DbContext
    {
        protected readonly IConfiguration Configuration;

        public Test1Context(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("StudentTrackerDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test1>().ToTable("Test1");
            modelBuilder.Entity<Test1>()
                .HasData(
                    new Test1
                    {
                        Id = 1,
                        Name = "TestOne",
                        TestOne = "Success"
                    }
                );
        }

        public DbSet<Test1> Test1 { get; set; }
        public DbSet<Test2> Test2 { get; set; }
    }
}
