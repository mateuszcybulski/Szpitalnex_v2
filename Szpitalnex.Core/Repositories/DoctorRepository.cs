using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base;
using Szpitalnex.Database.Repositories.Base.Interfaces;

namespace Szpitalnex.Database.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => mDbContext.Doctors;

        public DoctorRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Doctor> GetAllDoctors() 
        {
            //return DbSet.Include(x => x.Person).ThenInclude(y => y.Address);

            return  DbSet.Include(x => x.Person)
                                .ThenInclude(s => s.Address)
                          .Include(x => x.Specialization)
                         //.Include(s => s.Visits)
                                /* .ThenInclude(x => x.PrescribedMedicines)
                         .Include(x => x.Visits)
                                 .ThenInclude(x => x.Referral)
                         .Include(x => x.Visits)
                                 .ThenInclude(x => x.DiagnosedDiseases)
                         .Include(x => x.Specializations)
                                 .ThenInclude(x => x.Referrals)*/;


        }

        IEnumerable<Doctor> IRepository<Doctor>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
