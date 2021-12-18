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
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Group> Groups { get; set;}
        public DbSet<Couple> Couples { get; set;}
        public DbSet<Subject> Subjects { get; set;}
        public DbSet<TimeTable> TimeTables { get; set; }

        
    }
}
