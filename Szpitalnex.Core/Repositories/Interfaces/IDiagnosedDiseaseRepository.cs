using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IDiagnosedDiseaseRepository : IRepository<DiagnosedDisease>
    {
        IEnumerable<DiagnosedDisease> GetAllDiagnosedDiseases();
    }
}
