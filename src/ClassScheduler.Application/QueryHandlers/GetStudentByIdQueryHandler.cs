using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassScheduler.Application.QueryHandlers
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, StudentDto>
    {
        private readonly ClassSchedulerContext context;

        public GetStudentByIdQueryHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }

        public async Task<StudentDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await context.Students.FirstAsync(x => x.Id == request.Id, cancellationToken);
            return new StudentDto()
            {
                Id = student.Id,
                Name = student.Name
            };
        }
    }
}
