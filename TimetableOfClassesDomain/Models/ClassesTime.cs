using System;

namespace TimetableOfClasses.Domain
{
    public class ClassesTime
    {
        public Guid Id { get; set; }
        public int ClassesTimeNum { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        // Navigation Properties
        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
