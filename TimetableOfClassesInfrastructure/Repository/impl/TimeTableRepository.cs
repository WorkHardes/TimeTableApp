using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class TimeTableRepository : ITimeTableRepository
    {
        private Context context;

        public TimeTableRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<TimeTable> GetTimeTables()
        {
            return context.TimeTables.ToList();
        }

        public TimeTable GetTimeTableByID(Guid timeTableId)
        {
            return context.TimeTables.Find(timeTableId);
        }

        public void AddTimeTable(TimeTable timeTable)
        {
            context.TimeTables.Add(timeTable);

            context.SaveChanges();
        }

        public void UpdateTimeTable(Guid timeTableId, TimeTable newTimeTable)
        {
            TimeTable timeTable = context.TimeTables.Find(timeTableId);

            timeTable.AudienceId = newTimeTable.AudienceId;
            timeTable.LecturerId = newTimeTable.LecturerId;
            timeTable.ClassesTimeId = newTimeTable.ClassesTimeId;
            timeTable.SubjectId = newTimeTable.SubjectId;
            timeTable.GroupId = newTimeTable.GroupId;
            timeTable.Date = newTimeTable.Date;
            timeTable.DayOfTheWeek = newTimeTable.DayOfTheWeek;

            context.TimeTables.Update(timeTable);
            context.SaveChanges();
        }

        public void DeleteTimeTable(Guid timeTableId)
        {
            TimeTable timeTable = context.TimeTables.Find(timeTableId);
            context.TimeTables.Remove(timeTable);

            context.SaveChanges();
        }

        public void GenerateTimeTable()
        {
            int a = 1;
            a++;
        }
        public TimeTable GetTimeTableByLecturerID(Guid lecturerId)
        {
            return context.TimeTables.Find(lecturerId);
        }
        public TimeTable GetTimeTableByGroupID(Guid groupId)
        {
            return context.TimeTables.Find(groupId);
        }
        public TimeTable GetTimeTableByAudienceID(Guid audienceId)
        {
            return context.TimeTables.Find(audienceId);
        }
    }
}
