using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class Audience
    {
        public Guid Id { get; set; }
        public int AudienceNum { get; set; }
        public string Type { get; set; }

        public List<TimeTable> TimeTables { get; set; }
    }
}
