using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface ISemesterRepository
    {
        public IEnumerable<Semester> GetSemesters();
        Semester GetSemesterByID(Guid semesterId);
        void AddSemester(Semester semester);
        void UpdateSemester(Guid semesterid, Semester newSemester);
        void DeleteSemester(Guid semesterId);
    }
}
