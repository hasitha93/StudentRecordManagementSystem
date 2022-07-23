using Microsoft.EntityFrameworkCore;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;
using StudentRecordManagementSystem.Application.Models;
using StudentRecordManagementSystem.Infrastructure.DbContexts;

namespace StudentRecordManagementSystem.Infrastructure.Repositories
{
    public sealed class StudentReadRepository: IStudentReadRepository
    {
        private readonly ReadOnlyDbContext _dbContext;

        public StudentReadRepository(ReadOnlyDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<StudentModel> GetStudentByIdAsync(int id) => 
            await _dbContext.Set<StudentModel>().SingleOrDefaultAsync(s => s.Id == id);

        public async Task<List<StudentModel>> GetStudentListAsync() => 
            await _dbContext.Set<StudentModel>().ToListAsync();
    }
}
