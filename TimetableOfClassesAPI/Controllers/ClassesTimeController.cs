using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClassesTimesController : Controller
    {
        private IClassesTimeRepository classesTimeRepository;

        public ClassesTimesController(IClassesTimeRepository classesTimeRepository)
        {
            this.classesTimeRepository = classesTimeRepository;
        }

        // GET: api/<ClassesTimeController>
        [HttpGet("all")]
        public IEnumerable<ClassesTime> GetClassesTimes()
        {
            return classesTimeRepository.GetClassesTimes();
        }

        // GET api/<ClassesTimeController>/5
        [HttpGet("detail/{classesTimeId}")]
        public ClassesTime GetClassesTimeByID(Guid classesTimeId)
        {
            return classesTimeRepository.GetClassesTimeByID(classesTimeId);
        }

        // POST api/<ClassesTimeController>
        [HttpPost("create")]
        public void AddClassesTime(ClassesTime classesTime)
        {
            classesTimeRepository.AddClassesTime(classesTime);
        }

        // PUT api/<ClassesTimeController>/5
        [HttpPut("detail/{classesTimeId}")]
        public ClassesTime UpdateClassesTime(Guid classesTimeId, [FromBody] ClassesTime classesTime)
        {
            classesTimeRepository.UpdateClassesTime(classesTimeId, classesTime);
            return classesTimeRepository.GetClassesTimeByID(classesTimeId);
        }

        // DELETE api/<ClassesTimeController>/5
        [HttpDelete("detail/{classesTimeId}")]
        public void Delete(Guid classesTimeId)
        {
            classesTimeRepository.DeleteClassesTime(classesTimeId);
        }
    }
}
