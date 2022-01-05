using System;

namespace TimetableOfClasses.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public int GroupNum { get; set; }
        public int NumOfStudent { get; set; }

        // Navigation Properties
        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
        public Guid AcademicPlanId { get; set; }
        public AcademicPlan AcademicPlan { get; set; }
    }
}
