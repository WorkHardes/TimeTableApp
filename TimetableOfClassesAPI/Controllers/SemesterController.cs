using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemestersController : Controller
    {
        private ISemesterRepository semesterRepository;

        public SemestersController(ISemesterRepository semesterRepository)
        {
            this.semesterRepository = semesterRepository;
        }

        // GET: api/<SemesterController>
        [HttpGet]
        public IEnumerable<Semester> GetSemesters()
        {
            return semesterRepository.GetSemesters();
        }

        // GET api/<SemesterController>/5
        [HttpGet("{semesterId}")]
        public Semester GetSemesterByID(Guid semesterId)
        {
            return semesterRepository.GetSemesterByID(semesterId);
        }

        // POST api/<SemesterController>
        [HttpPost]
        public void AddSemester(Semester semester)
        {
            semesterRepository.AddSemester(semester);
        }

        // PUT api/<SemesterController>/5
        [HttpPut("{semesterId}")]
        public Semester UpdateSemester(Guid semesterId, [FromBody] Semester semester)
        {
            semesterRepository.UpdateSemester(semesterId, semester);
            return semesterRepository.GetSemesterByID(semesterId);
        }

        // DELETE api/<SemesterController>/5
        [HttpDelete("{semesterId}")]
        public void Delete(Guid semesterId)
        {
            semesterRepository.DeleteSemester(semesterId);
        }
    }
}
