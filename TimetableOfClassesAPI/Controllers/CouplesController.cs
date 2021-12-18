using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TimetableOfClasses.API.Controllers
{
    [ApiController]
    public class CouplesController : ControllerBase
    {
        private readonly Context _context;

        public CouplesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/couple/all")]
        public async Task<ActionResult<IEnumerable<Couple>>> GetAllCouples()
        {
            return await _context.Couples.ToListAsync();
        }

        [HttpPost]
        [Route("api/v1/couple/create")]
        public async Task<ActionResult<Couple>> CreateCouple(Couple c)
        {
            _context.Couples.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCouple", new { id = c.Id }, c);
        }

        [HttpGet]
        [Route("api/v1/couple/detail/id")]
        public async Task<ActionResult<IEnumerable<Couple>>> GetCoupleById()
        {
            return await _context.Couples.ToListAsync();
        }
        [HttpPut]
        [Route("api/v1/couple/detail/id")]
        public async Task<ActionResult<IEnumerable<Couple>>> UpdateCoupleById()
        {
            return await _context.Couples.ToListAsync();
        }
    }
}