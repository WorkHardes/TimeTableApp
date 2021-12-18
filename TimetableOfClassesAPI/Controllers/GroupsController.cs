using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly Context _context;

        public GroupsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/group/all")]
        public async Task<ActionResult<IEnumerable<Group>>> GetAllGroups()
        {
            return await _context.Groups.ToListAsync();
        }

        [HttpPost]
        [Route("api/v1/group/create")]
        public async Task<ActionResult<Group>> CreateGroup(Group c)
        {
            _context.Groups.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetGroup", new { id = c.Id }, c);
        }

        [HttpGet]
        [Route("api/v1/group/detail/id")]
        public async Task<ActionResult<IEnumerable<Group>>> GetGroupById()
        {
            return await _context.Groups.ToListAsync();
        }
        [HttpPut]
        [Route("api/v1/group/detail/id")]
        public async Task<ActionResult<IEnumerable<Group>>> UpdateGroupById()
        {
            return await _context.Groups.ToListAsync();
        }
    }
}