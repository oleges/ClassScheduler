using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Commands
{
    public class CreateStudentCommand : IRequest<StudentDto>
    {
        public string Name { get; set; }
    }
}
