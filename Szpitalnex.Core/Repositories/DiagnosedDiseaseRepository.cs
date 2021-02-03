using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;

namespace Szpitalnex.Database.Repositories
{
    public class DiagnosedDiseaseRepository : BaseRepository<DiagnosedDisease>, IDiagnosedDiseaseRepository
    {
        protected override DbSet<DiagnosedDisease> DbSet => mDbContext.DiagnosedDiseases;

        public DiagnosedDiseaseRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<DiagnosedDisease> GetAllDiagnosedDiseases()
        {
            return DbSet.Select(x => x);
        }
    }
}
