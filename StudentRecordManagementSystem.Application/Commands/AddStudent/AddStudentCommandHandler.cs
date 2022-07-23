using MediatR;
using StudentRecordManagementSystem.Application.Common;
using StudentRecordManagementSystem.Application.Interfaces.Repositories;
using StudentRecordManagementSystem.Domain.Entities;

namespace StudentRecordManagementSystem.Application.Commands.AddStudent
{
    public sealed class AddStudentCommandHandler: IRequestHandler<AddStudentCommand, BaseResponse>
    {
        private readonly IStudentRepository _studentRepo;

        public AddStudentCommandHandler(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
        }

        public async Task<BaseResponse> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FirstName, request.LastName, request.DateOfBirth, request.Email);
            _studentRepo.Add(student);
            var result = await _studentRepo.SaveChangesAsync(cancellationToken);
            return new BaseResponse(result);
        }
    }
}
