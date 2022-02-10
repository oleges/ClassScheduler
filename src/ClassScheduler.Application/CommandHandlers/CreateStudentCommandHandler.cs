using ClassScheduler.Application.Commands;
using ClassScheduler.Application.Dtos;
using ClassScheduler.Domain.Entities;
using ClassScheduler.Infrastructure.Contexts;
using MediatR;

namespace ClassScheduler.Application.CommandHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, StudentDto>
    {
        private readonly ClassSchedulerContext context;

        public CreateStudentCommandHandler(ClassSchedulerContext context)
        {
            this.context = context;
        }
        public async Task<StudentDto> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student()
            {
                Name = request.Name
            };
            await context.Students.AddAsync(student, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return new StudentDto()
            {
                Id = student.Id,
                Name = student.Name
            };
        }
    }
}
