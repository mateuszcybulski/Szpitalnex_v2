using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class ReferralRepository : BaseRepository<Referral>, IReferralRepository
    {
        protected override DbSet<Referral> DbSet => mDbContext.Referrals;

        public ReferralRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<Referral> GetAllReferrals()
        {
            return DbSet.Select(x => x);
        }

        IEnumerable<Referral> IRepository<Referral>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
