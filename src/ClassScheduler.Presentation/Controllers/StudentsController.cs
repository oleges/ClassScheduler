using ClassScheduler.Application.Commands;
using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClassScheduler.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentDto>> Get()
        {
            var request = new GetStudentsQuery();
            return await mediator.Send(request);
        }

        [HttpGet("{id:int}")]
        public async Task<StudentDto> Get(int id)
        {
            var request = new GetStudentByIdQuery()
            {
                Id = id
            };
            return await mediator.Send(request);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StudentDto>> Create(CreateStudentCommand request)
        {
            var response = await mediator.Send(request);
            return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
        }
    }
}
