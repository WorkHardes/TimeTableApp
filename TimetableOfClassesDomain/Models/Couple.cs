﻿using System;

namespace TimetableOfClasses.Domain
{
    public class Couple
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}