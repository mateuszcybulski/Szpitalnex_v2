﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class PrescribedMedicineRepository : BaseRepository<PrescribedMedicine>, IPrescribedMedicineRepository
    {
        protected override DbSet<PrescribedMedicine> DbSet => mDbContext.PrescribedMedicines;

        public PrescribedMedicineRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<PrescribedMedicine> GetAllPrescribedMedicines()
        {
            return DbSet.Select(x => x);
        }

        IEnumerable<PrescribedMedicine> IRepository<PrescribedMedicine>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
