using MediatR;
using StudentRecordManagementSystem.Application.Common;

namespace StudentRecordManagementSystem.Application.Commands.AddStudent
{
    public sealed class AddStudentCommand : IRequest<BaseResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
