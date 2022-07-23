using StudentRecordManagementSystem.Domain.Entities;

namespace StudentRecordManagementSystem.Application.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Delete(int id);
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
