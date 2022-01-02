using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudienceController : ControllerBase
    {
        // GET: api/<AudienceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AudienceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AudienceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AudienceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AudienceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
