using MediatR;
using StudentRecordManagementSystem.Application.Common;
using StudentRecordManagementSystem.Application.Extensions;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;

namespace StudentRecordManagementSystem.Application.Queries.StudentDetails
{
    public sealed class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, StudentResponse>
    {
        private readonly IStudentReadRepository _studentRepo;

        public GetStudentQueryHandler(IStudentReadRepository studentRepo)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
        }

        public async Task<StudentResponse> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepo.GetStudentByIdAsync(request.Id,cancellationToken);
            return student.ToStudentResponse();
        }
    }
}
