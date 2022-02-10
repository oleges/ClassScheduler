using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassScheduler.Application.QueryHandlers
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, IEnumerable<StudentDto>>
    {
        private readonly ClassSchedulerContext context;

        public GetStudentsQueryHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<StudentDto>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await context.Students.Select(x => new StudentDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync(cancellationToken);
        }
    }
}
