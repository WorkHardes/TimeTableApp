using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Audience> Audiences { get; set;}
        public DbSet<Lecturer> Teachers { get; set;}
        public DbSet<Group> Groups { get; set;}
        public DbSet<ClassesTime> ClassesTimes { get; set;}
        public DbSet<Subject> Subjects { get; set;}
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<AcademicPlan> AcademicPlan { get; set; }


    }
}
