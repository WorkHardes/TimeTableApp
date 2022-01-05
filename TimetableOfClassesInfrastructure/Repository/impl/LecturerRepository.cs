using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class LecturerRepository : ILecturerRepository
    {
        private Context context;

        public LecturerRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Lecturer> GetLecturers()
        {
            return context.Lecturers.ToList();
        }

        public Lecturer GetLecturerByID(Guid lecturerId)
        {
            return context.Lecturers.Find(lecturerId);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            context.Lecturers.Add(lecturer);

            context.SaveChanges();
        }

        public void UpdateLecturer(Guid lecturerId, Lecturer newLecturer)
        {
            Lecturer lecturer = context.Lecturers.Find(lecturerId);

            lecturer.FirstName = newLecturer.FirstName;
            lecturer.SecondName = newLecturer.SecondName;
            lecturer.Patronymic = newLecturer.Patronymic;

            context.Lecturers.Update(lecturer);
            context.SaveChanges();
        }

        public void DeleteLecturer(Guid lecturerId)
        {
            Lecturer lecturer = context.Lecturers.Find(lecturerId);
            context.Lecturers.Remove(lecturer);

            context.SaveChanges();
        }
    }
}
