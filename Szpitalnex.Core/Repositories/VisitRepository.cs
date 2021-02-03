using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;

namespace Szpitalnex.Database.Repositories
{
    public class VisitRepository : BaseRepository<Visit>, IVisitRepository
    {
        protected override DbSet<Visit> DbSet => mDbContext.Visits;

        public VisitRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Visit> GetAllVisitsWithDetails()
        {

            return DbSet.Include(x => x.Patient)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.PrescribedMedicines)
                            .ThenInclude(x => x.Medicine)
                        .Include(x => x.Referral)
                            .ThenInclude(x => x.Specialization)
                        .Include(x => x.DiagnosedDiseases)
                                .ThenInclude(x => x.Disease)
                                .Select(x => x);
        }

        public IEnumerable<Visit> GetAllVisits()
        {
            return DbSet.Include(x => x.Patient)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.Doctor)
                            .ThenInclude(x => x.Person)                            
                        .Select(x => x);


        }
    }
}
