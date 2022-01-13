using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using TimetableOfClasses.Domain;

namespace TimeTableOfClasses.Infrastructure.Repository.impl
{
    public class AudienceRepositoryTest
    {
        [Fact]
        public void GetAudiences()
        {
            Audience a = new Audience();
            a.AudienceId = 1;
            a.AudienceNum = 101;
            a.Type = "practices";

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.ToList()).Returns(new List<Audience>() { a });
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);

            var audiencees = audienceRepository.GetAudiences();

            Assert.IsNotNull(audiences);
            Assert.Equals(1, audiences.Count());
            Assert.Equals(1, audiences.First().AudienceId);
        }

        [Fact]
        public void GetAudienceById()
        {
            Audience a = new Audience();
            a.AudienceId = 1;
            a.AudienceNum = 101;
            a.Type = "practices";

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(a);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);

            var audienceObj = audienceRepository.GetAudienceByID(1);

            Assert.IsNotNull(audienceObj);
            Assert.Equals(1, audienceObj.AudienceId);
        }

        [Fact]
        public void AddAudience()
        {
            Audience a = new Audience();
            a.AudienceId = 1;
            a.AudienceNum = 101;
            a.Type = "practices";

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.AddAudience(a);

            dbContextMock.Verify(c => c.Audiencees.Add(It.IsAny<Audience>()), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Fact]
        public void UpdateAudience()
        {
            Audience aObj = new Audience();
            aObj.AudienceId = 1;
            aObj.Type = "practices";

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(aObj);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.UpdateAudience(1, aObj);

            dbContextMock.Verify(c => c.Audiencees.Find(1), Times.Once);
            dbContextMock.Verify(c => c.Audiencees.Update(aObj), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Fact]
        public void DeleteAudience()
        {
            Audience aObj = new Audience();
            aObj.AudienceId = 1;
            aObj.Type = "practices";

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(aObj);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.DeleteAudience(1);

            dbContextMock.Verify(c => c.Audiencees.Find(1), Times.Once);
            dbContextMock.Verify(c => c.Audiencees.Remove(aObj), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
