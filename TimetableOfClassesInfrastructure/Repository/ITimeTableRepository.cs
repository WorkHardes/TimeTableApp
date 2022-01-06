using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface ITimeTableRepository
    {
        public IEnumerable<TimeTable> GetTimeTables();
        TimeTable GetTimeTableByID(Guid timeTableId);
        void AddTimeTable(TimeTable timeTable);
        void UpdateTimeTable(Guid timeTableid, TimeTable newTimeTable);
        void DeleteTimeTable(Guid timeTableId);
        void GenerateTimeTable();
        TimeTable GetTimeTableByLecturerID(Guid lecturerId);
        TimeTable GetTimeTableByGroupID(Guid groupId);
        TimeTable GetTimeTableByAudienceID(Guid audienceId);

    }
}
