using Microsoft.EntityFrameworkCore;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;
using StudentRecordManagementSystem.Domain.Entities;
using StudentRecordManagementSystem.Infrastructure.DbContexts;

namespace StudentRecordManagementSystem.Infrastructure.Repositories
{
    public sealed class StudentRepository: IStudentRepository
    {
        private readonly WriteDbContext _dbContext;

        public StudentRepository(WriteDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void Add(Student student)
        {
            _dbContext.Add(student);
        }

        public void Delete(int id)
        {
            var student = _dbContext.Set<Student>().FirstOrDefaultAsync(s => s.Id == id);
            if (student == null)
            {
                throw new InvalidOperationException("Student record does not exist");
            }
            _dbContext.Remove(student);
        }

        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var result = await _dbContext.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}
