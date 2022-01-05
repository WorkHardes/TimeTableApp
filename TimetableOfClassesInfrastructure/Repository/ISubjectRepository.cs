using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface ISubjectRepository
    {
        public IEnumerable<Subject> GetSubjects();
        Subject GetSubjectByID(Guid subjectId);
        void AddSubject(Subject subject);
        void UpdateSubject(Guid subjectid, Subject newSubject);
        void DeleteSubject(Guid subjectId);
    }
}
