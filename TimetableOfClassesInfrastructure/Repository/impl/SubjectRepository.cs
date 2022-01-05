using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class SubjectRepository : ISubjectRepository
    {
        private Context context;

        public SubjectRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return context.Subjects.ToList();
        }

        public Subject GetSubjectByID(Guid subjectId)
        {
            return context.Subjects.Find(subjectId);
        }

        public void AddSubject(Subject subject)
        {
            context.Subjects.Add(subject);

            context.SaveChanges();
        }

        public void UpdateSubject(Guid subjectId, Subject newSubject)
        {
            Subject subject = context.Subjects.Find(subjectId);

            subject.Title = newSubject.Title;

            context.Subjects.Update(subject);
            context.SaveChanges();
        }

        public void DeleteSubject(Guid subjectId)
        {
            Subject subject = context.Subjects.Find(subjectId);
            context.Subjects.Remove(subject);

            context.SaveChanges();
        }
    }
}
