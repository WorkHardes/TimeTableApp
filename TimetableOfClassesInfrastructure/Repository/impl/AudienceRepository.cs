using System.Collections.Generic;
using System.Linq;

using TimetableOfClasses.Domain;

namespace TimetableOfClasses.Infrastructure.Repository.impl
{
    public class AudienceRepository : IAudienceRepository
    {
        private Context context;

        public AudienceRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Audience> GetAudiences()
        {
            return context.Audiences.ToList();
        }

        public Audience GetAudienceByID(int audienceId)
        {
            return context.Audiences.Find(audienceId);
        }

        public void AddAudience(Audience audience)
        {
            context.Audiences.Add(audience);

            context.SaveChanges();
        }

        public void UpdateAudience(int id, Audience newAudience)
        {
            Audience audience = context.Audiences.Find(id);
            audience.AudienceNum = newAudience.AudienceNum;
            audience.Type = newAudience.Type;
            context.Audiences.Update(audience);

            context.SaveChanges();
        }

        public void DeleteAudience(int audienceId)
        {
            Audience audience = context.Audiences.Find(audienceId);
            context.Audiences.Remove(audience);

            context.SaveChanges();
        }
    }
}
