using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;

namespace Szpitalnex.Database.Repositories
{
    public class SpecializationRepository : BaseRepository<Specialization>, ISpecializationRepository
    {
        protected override DbSet<Specialization> DbSet => mDbContext.Specializations;

        public SpecializationRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<Specialization> GetAllSpecializations()
        {
            return DbSet/*.Include(x => x.Referrals)*/.Select(x => x);
        }
    }
}
