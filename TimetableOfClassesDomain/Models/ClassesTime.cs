using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class ClassesTime
    {
        public Guid Id { get; set; }
        public int ClassesTimeNum { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        // Navigation Properties
        public List<TimeTable> TimeTables { get; set; }
    }
}
