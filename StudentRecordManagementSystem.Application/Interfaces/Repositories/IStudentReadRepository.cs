using StudentRecordManagementSystem.Application.Models;

namespace StudentRecordManagementSystem.Application.Interfaces.Repositories
{
    public interface IStudentReadRepository
    {
        Task<StudentModel> GetStudentByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<List<StudentModel>> GetStudentListAsync(CancellationToken cancellationToken = default);
    }
}
