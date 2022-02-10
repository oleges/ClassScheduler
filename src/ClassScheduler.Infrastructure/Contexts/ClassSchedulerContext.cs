using ClassScheduler.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassScheduler.Infrastructure.Contexts
{
    public class ClassSchedulerContext : DbContext
    {
        public ClassSchedulerContext(DbContextOptions<ClassSchedulerContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonException> LessonExceptions { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
