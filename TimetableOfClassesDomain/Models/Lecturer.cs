using System;
using System.Collections.Generic;

namespace TimetableOfClasses.Domain
{
    public class Lecturer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }

        public List<TimeTable> TimeTables { get; set; }
    }
}
