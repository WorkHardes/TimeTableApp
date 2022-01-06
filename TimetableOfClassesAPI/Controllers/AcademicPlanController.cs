using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AcademicPlansController : Controller
    {
        private IAcademicPlanRepository academicPlanRepository;

        public AcademicPlansController(IAcademicPlanRepository academicPlanRepository)
        {
            this.academicPlanRepository = academicPlanRepository;
        }

        // GET: api/<AcademicPlanController>
        [HttpGet("all")]
        public IEnumerable<AcademicPlan> GetAcademicPlans()
        {
            return academicPlanRepository.GetAcademicPlans();
        }

        // GET api/<AcademicPlanController>/5
        [HttpGet("detail/{academicPlanId}")]
        public AcademicPlan GetAcademicPlanByID(Guid academicPlanId)
        {
            return academicPlanRepository.GetAcademicPlanByID(academicPlanId);
        }

        // POST api/<AcademicPlanController>
        [HttpPost("create")]
        public void AddAcademicPlan(AcademicPlan academicPlan)
        {
            academicPlanRepository.AddAcademicPlan(academicPlan);
        }

        // PUT api/<AcademicPlanController>/5
        [HttpPut("detail/{academicPlanId}")]
        public AcademicPlan UpdateAcademicPlan(Guid academicPlanId, [FromBody] AcademicPlan academicPlan)
        {
            academicPlanRepository.UpdateAcademicPlan(academicPlanId, academicPlan);
            return academicPlanRepository.GetAcademicPlanByID(academicPlanId);
        }

        // DELETE api/<AcademicPlanController>/5
        [HttpDelete("detail/{academicPlanId}")]
        public void Delete(Guid academicPlanId)
        {
            academicPlanRepository.DeleteAcademicPlan(academicPlanId);
        }
    }
}
