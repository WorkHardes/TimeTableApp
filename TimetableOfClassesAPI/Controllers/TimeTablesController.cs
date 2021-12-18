using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class TimeTablesController : ControllerBase
    {
        private readonly Context _context;

        public TimeTablesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/timetable/all")]
        public async Task<ActionResult<IEnumerable<TimeTable>>> GetAllAudiences()
        {
            return await _context.TimeTables.ToListAsync();
        }

        [HttpGet]
        [Route("api/v1/timetable/detail/teacher/id")]
        public async Task<ActionResult<IEnumerable<TimeTable>>> GetTimeTableByTeacherId()
        {
            return await _context.TimeTables.ToListAsync();
        }

        [HttpGet]
        [Route("api/v1/timetable/detail/group/id")]
        public async Task<ActionResult<IEnumerable<TimeTable>>> GetTimeTableByGroupId()
        {
            return await _context.TimeTables.ToListAsync();
        }

        [HttpGet]
        [Route("api/v1/timetable/detail/audience/id")]
        public async Task<ActionResult<IEnumerable<TimeTable>>> GetTimeTableByAudienceId()
        {
            return await _context.TimeTables.ToListAsync();
        }


    }
}