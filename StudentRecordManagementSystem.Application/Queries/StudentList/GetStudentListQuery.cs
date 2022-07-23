using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Application.Queries.StudentList
{
    public sealed class GetStudentListQuery: IRequest<List<StudentResponse>>
    {
    }
}
