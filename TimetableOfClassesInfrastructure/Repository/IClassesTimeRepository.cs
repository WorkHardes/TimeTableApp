using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface IClassesTimeRepository
    {
        public IEnumerable<ClassesTime> GetClassesTimes();
        ClassesTime GetClassesTimeByID(Guid classesTimeId);
        void AddClassesTime(ClassesTime classesTime);
        void UpdateClassesTime(Guid classesTimeid, ClassesTime newClassesTime);
        void DeleteClassesTime(Guid classesTimeId);
    }
}
