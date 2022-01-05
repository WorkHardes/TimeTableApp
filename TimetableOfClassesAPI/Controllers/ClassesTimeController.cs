using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesTimesController : Controller
    {
        private IClassesTimeRepository classesTimeRepository;

        public ClassesTimesController(IClassesTimeRepository classesTimeRepository)
        {
            this.classesTimeRepository = classesTimeRepository;
        }

        // GET: api/<ClassesTimeController>
        [HttpGet]
        public IEnumerable<ClassesTime> GetClassesTimes()
        {
            return classesTimeRepository.GetClassesTimes();
        }

        // GET api/<ClassesTimeController>/5
        [HttpGet("{classesTimeId}")]
        public ClassesTime GetClassesTimeByID(Guid classesTimeId)
        {
            return classesTimeRepository.GetClassesTimeByID(classesTimeId);
        }

        // POST api/<ClassesTimeController>
        [HttpPost]
        public void AddClassesTime(ClassesTime classesTime)
        {
            classesTimeRepository.AddClassesTime(classesTime);
        }

        // PUT api/<ClassesTimeController>/5
        [HttpPut("{classesTimeId}")]
        public ClassesTime UpdateClassesTime(Guid classesTimeId, [FromBody] ClassesTime classesTime)
        {
            classesTimeRepository.UpdateClassesTime(classesTimeId, classesTime);
            return classesTimeRepository.GetClassesTimeByID(classesTimeId);
        }

        // DELETE api/<ClassesTimeController>/5
        [HttpDelete("{classesTimeId}")]
        public void Delete(Guid classesTimeId)
        {
            classesTimeRepository.DeleteClassesTime(classesTimeId);
        }
    }
}
