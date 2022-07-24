using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentRecordManagementSystem.Application.Commands.AddStudent;
using StudentRecordManagementSystem.Application.Queries.StudentDetails;
using StudentRecordManagementSystem.Application.Queries.StudentList;

namespace StudentRecordManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var result = await _mediator.Send(new GetStudentQuery(id));
            return Ok(result);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetStudentList()
        {
            var result = await _mediator.Send(new GetStudentListQuery());
            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateStudent([FromBody] AddStudentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
