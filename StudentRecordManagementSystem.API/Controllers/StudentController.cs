using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("list")]
        public async Task<IActionResult> GetOrganizationPropertyManagers()
        {
            var result = await _mediator.Send(new GetStudentListQuery());
            return Ok(result);
        }

    }
}
