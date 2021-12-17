using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses.Domain
{
    public class Audience
    {
        public Guid Id { get; set; }
        public int AudienceNum { get; set; }
        public int MaxNumOfSeats { get; set; }

        public Guid TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
