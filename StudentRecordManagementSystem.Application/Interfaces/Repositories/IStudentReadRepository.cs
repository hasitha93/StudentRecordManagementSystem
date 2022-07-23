using StudentRecordManagementSystem.Application.Models;

namespace StudentRecordManagementSystem.Application.Interfaces.Repositories
{
    public interface IStudentReadRepository
    {
        Task<StudentModel> GetStudentByIdAsync(int id);
        Task<List<StudentModel>> GetStudentListAsync();
    }
}
