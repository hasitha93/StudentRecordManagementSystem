using MediatR;
using StudentRecordManagementSystem.Application.Common;

namespace StudentRecordManagementSystem.Application.Queries.StudentList
{
    public sealed class GetStudentListQuery: IRequest<List<StudentResponse>>
    {
    }
}
