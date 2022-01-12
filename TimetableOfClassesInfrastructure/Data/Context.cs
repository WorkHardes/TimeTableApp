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

        public DbSet<Lecturer> Lecturers { get; set;}
        public DbSet<ClassesTime> ClassesTimes { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Group> Groups { get; set;}
        public DbSet<Subject> Subjects { get; set;}
        public DbSet<AcademicPlan> AcademicPlans { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecturer>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ClassesTime>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Audience>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Semester>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Group>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Subject>()
                .HasOne(c => c.ClassRoom)
                .WithMany(cr => cr.Classes)
                .HasForeignKey(c => c.ClassRoomId)
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
