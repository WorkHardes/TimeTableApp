using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class AudiencesController : ControllerBase
    {
        private readonly Context _context;

        public AudiencesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/audience/all")]
        public async Task<ActionResult<IEnumerable<Audience>>> GetAllAudiences()
        {
            return await _context.Audiences.ToListAsync();
        }

        [HttpPost]
        [Route("api/v1/audience/create")]
        public async Task<ActionResult<Audience>> CreateAudience(Audience c)
        {
            _context.Audiences.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAudience", new { id = c.Id }, c);
        }

        [HttpGet]
        [Route("api/v1/audience/detail/id")]
        public async Task<ActionResult<IEnumerable<Audience>>> GetAudienceById()
        {
            return await _context.Audiences.ToListAsync();
        }
        [HttpPut]
        [Route("api/v1/audience/detail/id")]
        public async Task<ActionResult<IEnumerable<Audience>>> UpdateAudienceById()
        {
            return await _context.Audiences.ToListAsync();
        }
    }
}