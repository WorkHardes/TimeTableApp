using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int NumOfStudent { get; set; }

        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
