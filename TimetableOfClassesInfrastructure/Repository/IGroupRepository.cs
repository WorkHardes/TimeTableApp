using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface IGroupRepository
    {
        public IEnumerable<Group> GetGroups();
        Group GetGroupByID(Guid groupId);
        void AddGroup(Group group);
        void UpdateGroup(Guid groupid, Group newGroup);
        void DeleteGroup(Guid groupId);
    }
}
