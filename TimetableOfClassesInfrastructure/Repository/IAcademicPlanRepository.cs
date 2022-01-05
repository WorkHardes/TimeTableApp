using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface IAcademicPlanRepository
    {
        public IEnumerable<AcademicPlan> GetAcademicPlans();
        AcademicPlan GetAcademicPlanByID(Guid academicPlanId);
        void AddAcademicPlan(AcademicPlan academicPlan);
        void UpdateAcademicPlan(Guid academicPlanid, AcademicPlan newAcademicPlan);
        void DeleteAcademicPlan(Guid academicPlanId);
    }
}
