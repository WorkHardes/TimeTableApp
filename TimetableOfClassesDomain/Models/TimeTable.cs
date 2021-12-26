using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class TimeTable
    {
        public Guid Id { get; set; }

        public Guid AudienceId { get; set; }
        public Guid LecturerId { get; set; }
        public Guid ClassTimeNum { get; set; }
        public Guid SubjectId { get; set; }
        public Guid GroupId { get; set; }
        public DateTime Date { get; set; }
        public string DayOfTheWeek { get; set; }


        // Navigation Properties
        public List<Audience> Audiences { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public List<ClassesTime> ClassTimes { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Group> Groups { get; set; }
        
       
    }
}
