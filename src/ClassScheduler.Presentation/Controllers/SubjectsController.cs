using ClassScheduler.Application.Commands;
using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClassScheduler.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IMediator mediator;

        public SubjectsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<SubjectDto>> Get()
        {
            var request = new GetSubjectsQuery();
            return await mediator.Send(request);
        }

        [HttpGet("{id:int}")]
        public async Task<SubjectDto> Get(int id)
        {
            var request = new GetSubjectByIdQuery()
            {
                Id = id
            };
            return await mediator.Send(request);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SubjectDto>> Create(CreateSubjectCommand request)
        {
            var response = await mediator.Send(request);
            return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
        }
    }
}
