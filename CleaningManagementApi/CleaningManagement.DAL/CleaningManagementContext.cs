using CleaningManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleaningManagement.DAL
{
    public class CleaningManagementDbContext : DbContext
    {
        public string DbPath { get; }

        public CleaningManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CleaningPlanEntity> CleaningPlans { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseInMemoryDatabase("CleaningContext");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CleaningPlanEntity>(CleaningPlanConfigure);
        }

        public void CleaningPlanConfigure(EntityTypeBuilder<CleaningPlanEntity> modelBuilder)
        {
            modelBuilder.HasKey(u => u.Id);

            modelBuilder.Property(b => b.Title).HasMaxLength(256).IsRequired();

            modelBuilder.Property(b => b.Description)
                .HasMaxLength(512).IsRequired();

            modelBuilder.Property(u => u.CreatedAt)
                .HasDefaultValueSql("DATETIME('now')");
        }
    }
}