using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        protected override DbSet<Medicine> DbSet => mDbContext.Medicines;

        public MedicineRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<Medicine> GetAllMedicines()
        {
            return DbSet.Select(x => x);
        }

        IEnumerable<Medicine> IRepository<Medicine>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
