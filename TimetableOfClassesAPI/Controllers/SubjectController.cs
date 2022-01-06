using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubjectsController : Controller
    {
        private ISubjectRepository subjectRepository;

        public SubjectsController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        // GET: api/<SubjectController>
        [HttpGet("all")]
        public IEnumerable<Subject> GetSubjects()
        {
            return subjectRepository.GetSubjects();
        }

        // GET api/<SubjectController>/5
        [HttpGet("detail/{subjectId}")]
        public Subject GetSubjectByID(Guid subjectId)
        {
            return subjectRepository.GetSubjectByID(subjectId);
        }

        // POST api/<SubjectController>
        [HttpPost("create")]
        public void AddSubject(Subject subject)
        {
            subjectRepository.AddSubject(subject);
        }

        // PUT api/<SubjectController>/5
        [HttpPut("detail/{subjectId}")]
        public Subject UpdateSubject(Guid subjectId, [FromBody] Subject subject)
        {
            subjectRepository.UpdateSubject(subjectId, subject);
            return subjectRepository.GetSubjectByID(subjectId);
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("detail/{subjectId}")]
        public void Delete(Guid subjectId)
        {
            subjectRepository.DeleteSubject(subjectId);
        }
    }
}
