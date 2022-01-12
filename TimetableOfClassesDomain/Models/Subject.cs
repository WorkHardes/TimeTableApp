using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        // Navigation Properties
        public List<TimeTable> TimeTables { get; set; }
        public List<AcademicPlan> AcademicPlans { get; set; }
    }
}
