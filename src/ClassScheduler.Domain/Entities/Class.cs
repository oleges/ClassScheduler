namespace ClassScheduler.Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Price> Prices { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public bool IsActive { get; set; }
    }
}
