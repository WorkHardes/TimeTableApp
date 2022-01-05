using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicPlansController : Controller
    {
        private IAcademicPlanRepository academicPlanRepository;

        public AcademicPlansController(IAcademicPlanRepository academicPlanRepository)
        {
            this.academicPlanRepository = academicPlanRepository;
        }

        // GET: api/<AcademicPlanController>
        [HttpGet]
        public IEnumerable<AcademicPlan> GetAcademicPlans()
        {
            return academicPlanRepository.GetAcademicPlans();
        }

        // GET api/<AcademicPlanController>/5
        [HttpGet("{academicPlanId}")]
        public AcademicPlan GetAcademicPlanByID(Guid academicPlanId)
        {
            return academicPlanRepository.GetAcademicPlanByID(academicPlanId);
        }

        // POST api/<AcademicPlanController>
        [HttpPost]
        public void AddAcademicPlan(AcademicPlan academicPlan)
        {
            academicPlanRepository.AddAcademicPlan(academicPlan);
        }

        // PUT api/<AcademicPlanController>/5
        [HttpPut("{academicPlanId}")]
        public AcademicPlan UpdateAcademicPlan(Guid academicPlanId, [FromBody] AcademicPlan academicPlan)
        {
            academicPlanRepository.UpdateAcademicPlan(academicPlanId, academicPlan);
            return academicPlanRepository.GetAcademicPlanByID(academicPlanId);
        }

        // DELETE api/<AcademicPlanController>/5
        [HttpDelete("{academicPlanId}")]
        public void Delete(Guid academicPlanId)
        {
            academicPlanRepository.DeleteAcademicPlan(academicPlanId);
        }
    }
}
