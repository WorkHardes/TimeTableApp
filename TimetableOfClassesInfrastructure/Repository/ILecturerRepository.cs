using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface ILecturerRepository
    {
        public IEnumerable<Lecturer> GetLecturers();
        Lecturer GetLecturerByID(Guid lecturerId);
        void AddLecturer(Lecturer lecturer);
        void UpdateLecturer(Guid lecturerid, Lecturer newLecturer);
        void DeleteLecturer(Guid lecturerId);
    }
}
