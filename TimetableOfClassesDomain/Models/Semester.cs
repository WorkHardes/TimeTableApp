using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class Semester
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        // Navigation Properties
        public List<AcademicPlan> AcademicPlans { get; set; }
    }
}
