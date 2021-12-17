using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class TimeTable
    {
        public Guid Id { get; set; }

        public Guid AudienceId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid GroupId { get; set; }
        public Guid CoupleId { get; set; }
        public Guid SubjectId { get; set; }

        // Navigation Properties
        public List<Audience> Audiences { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Group> Groups { get; set; }
        public List<Couple> Couples { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
