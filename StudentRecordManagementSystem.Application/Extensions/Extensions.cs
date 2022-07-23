using StudentRecordManagementSystem.Application.Models;
using StudentRecordManagementSystem.Application.Queries.StudentList;

namespace StudentRecordManagementSystem.Application.Extensions
{
    public static class Extensions
    {
        public static StudentResponse ToStudentResponse(this StudentModel studentModel) 
        {
            return new StudentResponse
            {
                FirstName = studentModel.FirstName,
                LastName = studentModel.LastName,
                DateOfBirth = studentModel.DateOfBirth,
                Email = studentModel.Email
            };
        }
    }
}
