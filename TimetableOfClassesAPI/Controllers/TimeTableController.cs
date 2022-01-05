using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTablesController : Controller
    {
        private ITimeTableRepository timeTableRepository;

        public TimeTablesController(ITimeTableRepository timeTableRepository)
        {
            this.timeTableRepository = timeTableRepository;
        }

        // GET: api/<TimeTableController>
        [HttpGet]
        public IEnumerable<TimeTable> GetTimeTables()
        {
            return timeTableRepository.GetTimeTables();
        }

        // GET api/<TimeTableController>/5
        [HttpGet("{timeTableId}")]
        public TimeTable GetTimeTableByID(Guid timeTableId)
        {
            return timeTableRepository.GetTimeTableByID(timeTableId);
        }

        // POST api/<TimeTableController>
        [HttpPost]
        public void AddTimeTable(TimeTable timeTable)
        {
            timeTableRepository.AddTimeTable(timeTable);
        }

        // PUT api/<TimeTableController>/5
        [HttpPut("{timeTableId}")]
        public TimeTable UpdateTimeTable(Guid timeTableId, [FromBody] TimeTable timeTable)
        {
            timeTableRepository.UpdateTimeTable(timeTableId, timeTable);
            return timeTableRepository.GetTimeTableByID(timeTableId);
        }

        // DELETE api/<TimeTableController>/5
        [HttpDelete("{timeTableId}")]
        public void Delete(Guid timeTableId)
        {
            timeTableRepository.DeleteTimeTable(timeTableId);
        }
    }
}
