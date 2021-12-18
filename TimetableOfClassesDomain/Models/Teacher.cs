﻿using System;

namespace TimetableOfClasses.Domain
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }

        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
