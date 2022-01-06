using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AudiencesController : Controller
    {
        private IAudienceRepository audienceRepository;

        public AudiencesController(IAudienceRepository audienceRepository)
        {
            this.audienceRepository = audienceRepository;
        }

        // GET: api/<AudienceController>
        [HttpGet("all")]
        public IEnumerable<Audience> GetAudiences()
        {
            return audienceRepository.GetAudiences();
        }

        // GET api/<AudienceController>/5
        [HttpGet("detail/{audienceId}")]
        public Audience GetAudienceByID(Guid audienceId)
        {
            return audienceRepository.GetAudienceByID(audienceId);
        }

        // POST api/<AudienceController>
        [HttpPost("create")]
        public void AddAudience(Audience audience)
        {
            audienceRepository.AddAudience(audience);
        }

        // PUT api/<AudienceController>/5
        [HttpPut("detail/{audienceId}")]
        public Audience UpdateAudience(Guid audienceId, [FromBody] Audience audience)
        {
            audienceRepository.UpdateAudience(audienceId, audience);
            return audienceRepository.GetAudienceByID(audienceId);
        }

        // DELETE api/<AudienceController>/5
        [HttpDelete("detail/{audienceId}")]
        public void Delete(Guid audienceId)
        {
            audienceRepository.DeleteAudience(audienceId);
        }
    }
}
