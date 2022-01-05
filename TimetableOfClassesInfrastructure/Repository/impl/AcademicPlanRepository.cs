using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class AcademicPlanRepository : IAcademicPlanRepository
    {
        private Context context;

        public AcademicPlanRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<AcademicPlan> GetAcademicPlans()
        {
            return context.AcademicPlans.ToList();
        }

        public AcademicPlan GetAcademicPlanByID(Guid academicPlanId)
        {
            return context.AcademicPlans.Find(academicPlanId);
        }

        public void AddAcademicPlan(AcademicPlan academicPlan)
        {
            context.AcademicPlans.Add(academicPlan);

            context.SaveChanges();
        }

        public void UpdateAcademicPlan(Guid academicPlanId, AcademicPlan newAcademicPlan)
        {
            AcademicPlan academicPlan = context.AcademicPlans.Find(academicPlanId);

            academicPlan.GroupId = newAcademicPlan.GroupId;
            academicPlan.SubjectId = newAcademicPlan.SubjectId;
            academicPlan.SemesterId = newAcademicPlan.SemesterId;
            academicPlan.NumOfLectures = newAcademicPlan.NumOfLectures;
            academicPlan.NumOfPractices = newAcademicPlan.NumOfPractices;
            academicPlan.NumOfLabs = newAcademicPlan.NumOfLabs;

            context.AcademicPlans.Update(academicPlan);
            context.SaveChanges();
        }

        public void DeleteAcademicPlan(Guid academicPlanId)
        {
            AcademicPlan academicPlan = context.AcademicPlans.Find(academicPlanId);
            context.AcademicPlans.Remove(academicPlan);

            context.SaveChanges();
        }
    }
}
