using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SemestersController : Controller
    {
        private ISemesterRepository semesterRepository;

        public SemestersController(ISemesterRepository semesterRepository)
        {
            this.semesterRepository = semesterRepository;
        }

        // GET: api/<SemesterController>
        [HttpGet("all")]
        public IEnumerable<Semester> GetSemesters()
        {
            return semesterRepository.GetSemesters();
        }

        // GET api/<SemesterController>/5
        [HttpGet("detail/{semesterId}")]
        public Semester GetSemesterByID(Guid semesterId)
        {
            return semesterRepository.GetSemesterByID(semesterId);
        }

        // POST api/<SemesterController>
        [HttpPost("create")]
        public void AddSemester(Semester semester)
        {
            semesterRepository.AddSemester(semester);
        }

        // PUT api/<SemesterController>/5
        [HttpPut("detail/{semesterId}")]
        public Semester UpdateSemester(Guid semesterId, [FromBody] Semester semester)
        {
            semesterRepository.UpdateSemester(semesterId, semester);
            return semesterRepository.GetSemesterByID(semesterId);
        }

        // DELETE api/<SemesterController>/5
        [HttpDelete("detail/{semesterId}")]
        public void Delete(Guid semesterId)
        {
            semesterRepository.DeleteSemester(semesterId);
        }
    }
}
