using ClassScheduler.Application.Dtos;
using ClassScheduler.Application.Queries;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassScheduler.Application.QueryHandlers
{
    public class GetSubjectByIdQueryHandler : IRequestHandler<GetSubjectByIdQuery, SubjectDto>
    {
        private readonly ClassSchedulerContext context;

        public GetSubjectByIdQueryHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }

        public async Task<SubjectDto> Handle(GetSubjectByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await context.Subjects.FirstAsync(x => x.Id == request.Id, cancellationToken);
            return new SubjectDto()
            {
                Id = subject.Id,
                Name = subject.Name
            };
        }
    }
}
