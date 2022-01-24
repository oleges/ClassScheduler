using ClassScheduler.Domain.Enums;

namespace ClassScheduler.Domain.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public RepeatInterval? RepeatInterval { get; set; }
        public DateTimeOffset? RepeatUntil { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public ICollection<LessonException> LessonExceptions { get; set; }
    }
}
