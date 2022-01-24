namespace ClassScheduler.Domain.Entities
{
    public class LessonException
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
