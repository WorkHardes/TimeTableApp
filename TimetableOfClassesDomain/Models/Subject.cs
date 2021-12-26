using System;

namespace TimetableOfClasses.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        // Navigation Properties
        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
        public Guid AcademicPlanId { get; set; }
        public AcademicPlan AcademicPlan { get; set; }
    }
}
