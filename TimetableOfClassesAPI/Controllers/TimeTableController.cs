using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]/")]
    [ApiController]
    public class TimeTablesController : Controller
    {
        private ITimeTableRepository timeTableRepository;

        public TimeTablesController(ITimeTableRepository timeTableRepository)
        {
            this.timeTableRepository = timeTableRepository;
        }

        [HttpGet("all")]
        public IEnumerable<TimeTable> GetTimeTables()
        {
            return timeTableRepository.GetTimeTables();
        }

        [HttpGet("detail/{timeTableId}")]
        public TimeTable GetTimeTableByID(Guid timeTableId)
        {
            return timeTableRepository.GetTimeTableByID(timeTableId);
        }

        [HttpPost("create")]
        public void AddTimeTable(TimeTable timeTable)
        {
            timeTableRepository.AddTimeTable(timeTable);
        }

        [HttpPut("detail/{timeTableId}")]
        public TimeTable UpdateTimeTable(Guid timeTableId, [FromBody] TimeTable timeTable)
        {
            timeTableRepository.UpdateTimeTable(timeTableId, timeTable);
            return timeTableRepository.GetTimeTableByID(timeTableId);
        }

        [HttpDelete("detail/{timeTableId}")]
        public void Delete(Guid timeTableId)
        {
            timeTableRepository.DeleteTimeTable(timeTableId);
        }

        [HttpPost("generate")]
        public void GenerateTimeTable()
        {
            timeTableRepository.GenerateTimeTable();
        }

        [HttpGet("detail/Lecturers/lecturerId")]
        public TimeTable GetTimeTableByLecturerID(Guid lecturerId)
        {
            return timeTableRepository.GetTimeTableByLecturerID(lecturerId);
        }

        [HttpGet("detail/Groups/groupId")]
        public TimeTable GetTimeTableByGroupID(Guid groupId)
        {
            return timeTableRepository.GetTimeTableByGroupID(groupId);
        }

        [HttpGet("detail/Audiences/audienceId")]
        public TimeTable GetTimeTableByAudienceID(Guid audienceId)
        {
            return timeTableRepository.GetTimeTableByAudienceID(audienceId);
        }
    }
}
