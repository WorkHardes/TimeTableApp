using TimetableOfClasses.Domain;
using System.Collections.Generic;

namespace TimetableOfClasses.Infrastructure.Repository
{
    public interface IAudienceRepository
    {
        public IEnumerable<Audience> GetAudiences();
        Audience GetAudienceByID(int audienceId);
        void AddAudience(Audience audience);
        void UpdateAudience(int id, Audience newAudience);
        void DeleteAudience(int classId);
    }
}
