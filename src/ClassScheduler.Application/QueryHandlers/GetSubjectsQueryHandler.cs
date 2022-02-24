using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassScheduler.Application.QueryHandlers
{
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, IEnumerable<SubjectDto>>
    {
        private readonly ClassSchedulerContext context;

        public GetSubjectsQueryHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<SubjectDto>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            return await context.Subjects.Select(x => new SubjectDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync(cancellationToken);
        }
    }
}
