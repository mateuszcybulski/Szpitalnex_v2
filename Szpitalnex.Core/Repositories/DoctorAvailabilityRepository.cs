using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Entities.Base;
using Szpitalnex.Database.Repositories.Base;
using Szpitalnex.Database.Repositories.Interfaces;

namespace Szpitalnex.Database.Repositories
{
    public class DoctorAvailabilityRepository : BaseRepository<DoctorAvailability>, IDoctorAvailabilityRepository
    {
        protected override DbSet<DoctorAvailability> DbSet => mDbContext.DoctorAvailabilities;

        public DoctorAvailabilityRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<DoctorAvailability> GetAllDoctorAvailability()
        {
            return DbSet.Include(x => x.Doctor)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.Doctor)
                            .ThenInclude(x => x.Specialization);
        }
        public IEnumerable<DoctorAvailability> GetAllDoctorAvailabilityTrue()
        {
            return DbSet.Include(x => x.Doctor)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.Doctor)
                            .ThenInclude(x => x.Specialization)
                         .Where(x => x.Actual == true);
        }
        public IEnumerable<DoctorAvailability> GetAllDoctorAvailabilityFalse()
        {
            return DbSet.Include(x => x.Doctor)
                            .ThenInclude(x => x.Person)
                        .Include(x => x.Doctor)
                            .ThenInclude(x => x.Specialization)
                         .Where(x => x.Actual == false);
        }
        /*
        IEnumerable<DoctorAvailability> IRepository<DoctorAvailability>.GetAll()
        {
            throw new NotImplementedException();
        }*/
    }
}
