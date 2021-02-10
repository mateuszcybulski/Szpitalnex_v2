using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IVisitRepository : IRepository<Visit>
    {
        IEnumerable<Visit> GetAllVisits();
        IEnumerable<Visit> GetAllVisitsWithDetails();
    }
}
