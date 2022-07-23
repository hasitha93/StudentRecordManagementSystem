using Microsoft.EntityFrameworkCore;
using StudentRecordManagementSystem.Application.Models;

namespace StudentRecordManagementSystem.Infrastructure.DbContexts
{
    public sealed class ReadOnlyDbContext : DbContext
    {
        public ReadOnlyDbContext(DbContextOptions<ReadOnlyDbContext> options)
        : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().ToView("Student");
        }

        public override int SaveChanges()
        {
            throw new AccessViolationException("This context is read-only");
        }
    }
}