using System;

namespace TimetableOfClasses.Domain
{
    public class TimeTable
    {
        public Guid Id { get; set; }

        public Guid AudienceId { get; set; }
        public Audience Audience { get; set; }

        public Guid LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        public Guid ClassesTimeId { get; set; }
        public ClassesTime ClassesTime { get; set; }

        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public DateTime Date { get; set; }
        public string DayOfTheWeek { get; set; }
    }
}
