using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly Context _context;

        public TeachersController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/teacher/all")]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAllTeachers()
        {
            return await _context.Teachers.ToListAsync();
        }

        [HttpPost]
        [Route("api/v1/teacher/create")]
        public async Task<ActionResult<Teacher>> CreateTeacher(Teacher c)
        {
            _context.Teachers.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTeacher", new { id = c.Id }, c);
        }

        [HttpGet]
        [Route("api/v1/teacher/detail/id")]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacherById()
        {
            return await _context.Teachers.ToListAsync();
        }
        [HttpPut]
        [Route("api/v1/teacher/detail/id")]
        public async Task<ActionResult<IEnumerable<Teacher>>> UpdateTeacherById()
        {
            return await _context.Teachers.ToListAsync();
        }
    }
}