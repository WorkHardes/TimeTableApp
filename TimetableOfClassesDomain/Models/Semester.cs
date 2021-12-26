using System;

namespace TimetableOfClasses.Domain
{
    public class Semester
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        // Navigation Properties
        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
        public Guid AcademicPlanId { get; set; }
        public AcademicPlan AcademicPlan { get; set; }
    }
}
