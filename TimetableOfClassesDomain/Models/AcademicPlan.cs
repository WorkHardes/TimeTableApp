using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class AcademicPlan
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }

        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }

        public int NumOfLectures { get; set; }
        public int NumOfPractices { get; set; }
        public int NumOfLabs { get; set; }
    }
}
