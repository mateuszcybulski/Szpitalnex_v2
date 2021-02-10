using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class VisitRepository : BaseRepository<Visit>, IVisitRepository
    {
        protected override DbSet<Visit> DbSet => mDbContext.Visits;

        public VisitRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Visit> GetAllVisitsWithDetails()
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

        public IQueryable<Visit> GetAllVisits()
        {
            return DbSet.Include(x => x.Patient)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.Doctor)
                            .ThenInclude(x => x.Person)                            
                        .Select(x => x);


        }

        /*
        IEnumerable<Visit> IRepository<Visit>.GetAll()
        {
            throw new System.NotImplementedException();
        }*/
    }
}
