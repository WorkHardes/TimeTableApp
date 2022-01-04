using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AudiencesController : Controller
    {
        private IAudienceRepository audienceRepository;

        public AudiencesController(IAudienceRepository audienceRepository)
        {
            this.audienceRepository = audienceRepository;
        }

        // GET: api/<AudienceController>
        [HttpGet]
        public IEnumerable<Audience> GetAudiences()
        {
            return audienceRepository.GetAudiences();
        }

        // GET api/<AudienceController>/5
        [HttpGet("{audienceId}")]
        public Audience GetAudienceByID(int audienceId)
        {
            return audienceRepository.GetAudienceByID(audienceId);
        }

        // POST api/<AudienceController>
        [HttpPost]
        public void AddAudience(Audience audience)
        {
            audienceRepository.AddAudience(audience);
        }

        // PUT api/<AudienceController>/5
        [HttpPut("{audienceId}")]
        public Audience UpdateAudience(int audienceId, [FromBody] Audience audience)
        {
            audienceRepository.UpdateAudience(audienceId, audience);
            return audienceRepository.GetAudienceByID(audienceId);
        }

        // DELETE api/<AudienceController>/5
        [HttpDelete("{audienceId}")]
        public void Delete(int audienceId)
        {
            audienceRepository.DeleteAudience(audienceId);
        }
    }
}
