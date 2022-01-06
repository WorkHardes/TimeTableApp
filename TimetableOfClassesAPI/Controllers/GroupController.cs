using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using TimetableOfClasses.Domain;
using TimetableOfClasses.Infrastructure.Repository;

namespace TimetableOfClasses.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GroupsController : Controller
    {
        private IGroupRepository groupRepository;

        public GroupsController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        // GET: api/<GroupController>
        [HttpGet("all")]
        public IEnumerable<Group> GetGroups()
        {
            return groupRepository.GetGroups();
        }

        // GET api/<GroupController>/5
        [HttpGet("detail/{groupId}")]
        public Group GetGroupByID(Guid groupId)
        {
            return groupRepository.GetGroupByID(groupId);
        }

        // POST api/<GroupController>
        [HttpPost("create")]
        public void AddGroup(Group group)
        {
            groupRepository.AddGroup(group);
        }

        // PUT api/<GroupController>/5
        [HttpPut("detail/{groupId}")]
        public Group UpdateGroup(Guid groupId, [FromBody] Group group)
        {
            groupRepository.UpdateGroup(groupId, group);
            return groupRepository.GetGroupByID(groupId);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("detail/{groupId}")]
        public void Delete(Guid groupId)
        {
            groupRepository.DeleteGroup(groupId);
        }
    }
}
