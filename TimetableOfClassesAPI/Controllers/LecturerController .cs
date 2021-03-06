using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LecturersController : Controller
    {
        private ILecturerRepository lecturerRepository;

        public LecturersController(ILecturerRepository lecturerRepository)
        {
            this.lecturerRepository = lecturerRepository;
        }

        // GET: api/<LecturerController>
        [HttpGet("all")]
        public IEnumerable<Lecturer> GetLecturers()
        {
            return lecturerRepository.GetLecturers();
        }

        // GET api/<LecturerController>/5
        [HttpGet("detail/{lecturerId}")]
        public Lecturer GetLecturerByID(Guid lecturerId)
        {
            return lecturerRepository.GetLecturerByID(lecturerId);
        }

        // POST api/<LecturerController>
        [HttpPost("create")]
        public void AddLecturer(Lecturer lecturer)
        {
            lecturerRepository.AddLecturer(lecturer);
        }

        // PUT api/<LecturerController>/5
        [HttpPut("detail/{lecturerId}")]
        public Lecturer UpdateLecturer(Guid lecturerId, [FromBody] Lecturer lecturer)
        {
            lecturerRepository.UpdateLecturer(lecturerId, lecturer);
            return lecturerRepository.GetLecturerByID(lecturerId);
        }

        // DELETE api/<LecturerController>/5
        [HttpDelete("detail/{lecturerId}")]
        public void Delete(Guid lecturerId)
        {
            lecturerRepository.DeleteLecturer(lecturerId);
        }
    }
}
