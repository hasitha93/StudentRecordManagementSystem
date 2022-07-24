using MediatR;
using StudentRecordManagementSystem.Application.Common;
using StudentRecordManagementSystem.Application.Extensions;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;

namespace StudentRecordManagementSystem.Application.Queries.StudentList
{
    public sealed class GetStudentListQueryHandler : IRequestHandler<GetStudentListQuery, List<StudentResponse>>
    {
        private readonly IStudentReadRepository _studentRepo;

        public GetStudentListQueryHandler(IStudentReadRepository studentRepo)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
        }

        public async Task<List<StudentResponse>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepo.GetStudentListAsync(cancellationToken);
            return students.Select(x => x.ToStudentResponse()).ToList();
        }
    }
}
