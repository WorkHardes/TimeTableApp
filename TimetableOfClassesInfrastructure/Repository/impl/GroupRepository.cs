using System;
using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class GroupRepository : IGroupRepository
    {
        private Context context;

        public GroupRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Group> GetGroups()
        {
            return context.Groups.ToList();
        }

        public Group GetGroupByID(Guid groupId)
        {
            return context.Groups.Find(groupId);
        }

        public void AddGroup(Group group)
        {
            context.Groups.Add(group);

            context.SaveChanges();
        }

        public void UpdateGroup(Guid groupId, Group newGroup)
        {
            Group group = context.Groups.Find(groupId);

            group.GroupNum = newGroup.GroupNum;
            group.NumOfStudent = newGroup.NumOfStudent;

            context.Groups.Update(group);
            context.SaveChanges();
        }

        public void DeleteGroup(Guid groupId)
        {
            Group group = context.Groups.Find(groupId);
            context.Groups.Remove(group);

            context.SaveChanges();
        }
    }
}
