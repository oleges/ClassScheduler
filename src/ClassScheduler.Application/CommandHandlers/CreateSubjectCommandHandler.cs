using ClassScheduler.Application.Commands;
using ClassScheduler.Application.Dtos;
using ClassScheduler.Domain.Entities;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;

namespace ClassScheduler.Application.CommandHandlers
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, SubjectDto>
    {
        private readonly ClassSchedulerContext context;

        public CreateSubjectCommandHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }
        public async Task<SubjectDto> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subject = new Subject()
            {
                Name = request.Name
            };
            await context.Subjects.AddAsync(subject, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return new SubjectDto()
            {
                Id = subject.Id,
                Name = subject.Name
            };
        }
    }
}
