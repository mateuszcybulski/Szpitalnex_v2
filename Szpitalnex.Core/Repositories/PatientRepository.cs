using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        protected override DbSet<Patient> DbSet => mDbContext.Patients;

        public PatientRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<Patient> GetAllPatients()
        {
            return DbSet.Include(x => x.Person)
                                .ThenInclude(s => s.Address);
        }
        /*
        IEnumerable<Patient> IRepository<Patient>.GetAll()
        {
            throw new System.NotImplementedException();
        }*/
    }
}
