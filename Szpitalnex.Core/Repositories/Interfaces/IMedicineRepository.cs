using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IMedicineRepository : IRepository<Medicine>
    {
        IEnumerable<Medicine> GetAllMedicines();
    }
}
