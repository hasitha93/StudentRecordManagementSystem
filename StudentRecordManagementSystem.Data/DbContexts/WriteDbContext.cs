using Microsoft.EntityFrameworkCore;

namespace StudentRecordManagementSystem.Infrastructure.DbContexts
{
    public sealed class WriteDbContext: DbContext
    {
        public WriteDbContext() { }

        public WriteDbContext(DbContextOptions<WriteDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Configurations.StudentConfiguration).Assembly);
        }
    }
}
