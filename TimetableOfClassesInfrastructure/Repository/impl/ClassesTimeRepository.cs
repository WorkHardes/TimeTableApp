using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class ClassesTimeRepository : IClassesTimeRepository
    {
        private Context context;

        public ClassesTimeRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<ClassesTime> GetClassesTimes()
        {
            return context.ClassesTimes.ToList();
        }

        public ClassesTime GetClassesTimeByID(Guid classesTimeId)
        {
            return context.ClassesTimes.Find(classesTimeId);
        }

        public void AddClassesTime(ClassesTime classesTime)
        {
            context.ClassesTimes.Add(classesTime);

            context.SaveChanges();
        }

        public void UpdateClassesTime(Guid classesTimeid, ClassesTime newClassesTime)
        {
            ClassesTime classesTime = context.ClassesTimes.Find(classesTimeid);

            classesTime.ClassesTimeNum = newClassesTime.ClassesTimeNum;
            classesTime.BeginTime = newClassesTime.BeginTime;
            classesTime.EndTime = newClassesTime.EndTime;

            context.ClassesTimes.Update(classesTime);
            context.SaveChanges();
        }

        public void DeleteClassesTime(Guid classesTimeId)
        {
            ClassesTime classesTime = context.ClassesTimes.Find(classesTimeId);
            context.ClassesTimes.Remove(classesTime);

            context.SaveChanges();
        }
    }
}
