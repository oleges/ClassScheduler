using ClassScheduler.Application.Dtos;
using MediatR;

namespace ClassScheduler.Application.Queries
{
    public class GetSubjectByIdQuery : IRequest<SubjectDto>
    {
        public int Id { get; set; }
    }
}
