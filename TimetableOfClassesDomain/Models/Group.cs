using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public int GroupNum { get; set; }
        public int NumOfStudent { get; set; }

        public List<TimeTable> TimeTables { get; set; }

    }
}
