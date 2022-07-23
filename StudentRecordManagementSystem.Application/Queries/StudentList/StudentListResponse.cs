namespace StudentRecordManagementSystem.Application.Queries.StudentList
{
    public sealed class StudentResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
