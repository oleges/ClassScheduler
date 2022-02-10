using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDto>
    {
        public int Id { get; set; }
    }
}
