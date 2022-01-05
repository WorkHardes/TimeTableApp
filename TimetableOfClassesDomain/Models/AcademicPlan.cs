using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class AcademicPlan
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid SemesterId { get; set; }
        public int NumOfLectures { get; set; }
        public int NumOfPractices { get; set; }
        public int NumOfLabs { get; set; }

        // Navigation Properties
        public List<Group> Groups { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Semester> Semesters { get; set; }
    }
}
