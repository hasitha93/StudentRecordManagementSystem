using MediatR;
using StudentRecordManagementSystem.Application.Common;

namespace StudentRecordManagementSystem.Application.Queries.StudentDetails
{
    public sealed class GetStudentQuery : IRequest<StudentResponse>
    {
        public int Id { get; set; }

        public GetStudentQuery(int id)
        {
            Id = id;
        }
    }
}
