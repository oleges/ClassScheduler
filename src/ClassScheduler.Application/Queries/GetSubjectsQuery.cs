using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Queries
{
    public class GetSubjectsQuery : IRequest<IEnumerable<SubjectDto>>
    {
    }
}
