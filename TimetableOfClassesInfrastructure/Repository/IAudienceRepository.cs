using System;
using System.Collections.Generic;

using TimetableOfClasses.Domain;


namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface IAudienceRepository
    {
        public IEnumerable<Audience> GetAudiences();
        Audience GetAudienceByID(Guid audienceId);
        void AddAudience(Audience audience);
        void UpdateAudience(Guid audienceid, Audience newAudience);
        void DeleteAudience(Guid audienceId);
    }
}