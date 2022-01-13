using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Moq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class AudienceRepositoryTest
    {
        [Fact]
        public void GetAudiences()
        {
            Audience a = new()
            {
                Id = new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"),
                AudienceNum = 101,
                Type = "practices"
            };

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.ToList()).Returns(new List<Audience>() { a });
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);

            var audiences = audienceRepository.GetAudiences();

            Assert.NotNull(audiences);
            Assert.Equal(new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"), audiences.First().Id);
        }

        [Fact]
        public void AddAudience()
        {
            Audience a = new()
            {
                Id = new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"),
                AudienceNum = 101,
                Type = "practices"
            };

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.AddAudience(a);

            dbContextMock.Verify(c => c.Audiences.Add(It.IsAny<Audience>()), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Fact]
        public void GetAudienceById()
        {
            Audience a = new()
            {
                Id = new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"),
                AudienceNum = 101,
                Type = "practices"
            };

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(a);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);

            var audienceObj = audienceRepository.GetAudienceByID(new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"));

            Assert.NotNull(audienceObj);
            Assert.Equal(new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"), audienceObj.Id);
        }

        [Fact]
        public void UpdateAudience()
        {
            Audience aObj = new()
            {
                Id = new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"),
                AudienceNum = 101,
                Type = "practices"
            };

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(aObj);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.UpdateAudience(new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"), aObj);

            dbContextMock.Verify(c => c.Audiences.Find(1), Times.Once);
            dbContextMock.Verify(c => c.Audiences.Update(aObj), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [Fact]
        public void DeleteAudience()
        {
            Audience aObj = new()
            {
                Id = new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"),
                AudienceNum = 101,
                Type = "practices"
            };

            var dbContextMock = new Mock<Context>();
            var dbSetMock = new Mock<DbSet<Audience>>();
            dbSetMock.Setup(s => s.Find(1)).Returns(aObj);
            dbContextMock.Setup(s => s.Set<Audience>()).Returns(dbSetMock.Object);

            var audienceRepository = new AudienceRepository(dbContextMock.Object);
            audienceRepository.DeleteAudience(new Guid("d81c0b4b-a9ce-44c5-d8f3-08d9d6a81919"));

            dbContextMock.Verify(c => c.Audiences.Find(1), Times.Once);
            dbContextMock.Verify(c => c.Audiences.Remove(aObj), Times.Once);
            dbContextMock.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
