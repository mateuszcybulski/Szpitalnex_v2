using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IDiseaseRepository : IRepository<Disease>
    {
        IEnumerable<Disease> GetAllDiseases();
    }
}
