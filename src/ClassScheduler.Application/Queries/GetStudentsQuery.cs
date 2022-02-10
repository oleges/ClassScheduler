using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Queries
{
    public class GetStudentsQuery : IRequest<IEnumerable<StudentDto>>
    {
    }
}
