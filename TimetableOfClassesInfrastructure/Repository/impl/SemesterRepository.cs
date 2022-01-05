using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class SemesterRepository : ISemesterRepository
    {
        private Context context;

        public SemesterRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Semester> GetSemesters()
        {
            return context.Semesters.ToList();
        }

        public Semester GetSemesterByID(Guid semesterId)
        {
            return context.Semesters.Find(semesterId);
        }

        public void AddSemester(Semester semester)
        {
            context.Semesters.Add(semester);

            context.SaveChanges();
        }

        public void UpdateSemester(Guid semesterId, Semester newSemester)
        {
            Semester semester = context.Semesters.Find(semesterId);

            semester.Type = newSemester.Type;
            semester.Year = newSemester.Year;

            context.Semesters.Update(semester);
            context.SaveChanges();
        }

        public void DeleteSemester(Guid semesterId)
        {
            Semester semester = context.Semesters.Find(semesterId);
            context.Semesters.Remove(semester);

            context.SaveChanges();
        }
    }
}
