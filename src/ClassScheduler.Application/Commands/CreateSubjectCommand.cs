using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Commands
{
    public class CreateSubjectCommand : IRequest<SubjectDto>
    {
        public string Name { get; set; }
    }
}
