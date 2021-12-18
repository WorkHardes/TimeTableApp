using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly Context _context;

        public SubjectsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/subject/all")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetAllSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }

        [HttpPost]
        [Route("api/v1/subject/create")]
        public async Task<ActionResult<Subject>> CreateSubject(Subject c)
        {
            _context.Subjects.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSubject", new { id = c.Id }, c);
        }

        [HttpGet]
        [Route("api/v1/subject/detail/id")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjectById()
        {
            return await _context.Subjects.ToListAsync();
        }
        [HttpPut]
        [Route("api/v1/subject/detail/id")]
        public async Task<ActionResult<IEnumerable<Subject>>> UpdateSubjectById()
        {
            return await _context.Subjects.ToListAsync();
        }
    }
}