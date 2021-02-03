using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Entities.Base;
using Szpitalnex.Database.Repositories.Base;
using Szpitalnex.Database.Repositories.Base.Interfaces;

namespace Szpitalnex.Database.Repositories
{
    public class DiseaseRepository : BaseRepository<Disease>, IDiseaseRepository
    {

        protected override DbSet<Disease> DbSet => mDbContext.Diseases;

        public DiseaseRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Disease> GetAllDiseases()
        {
            return DbSet.Select(x => x);
        }

    }
}
