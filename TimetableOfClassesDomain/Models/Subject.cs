using System;

namespace TimetableOfClasses.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
