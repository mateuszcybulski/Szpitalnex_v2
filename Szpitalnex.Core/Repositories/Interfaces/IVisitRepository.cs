using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IVisitRepository : IRepository<Visit>
    {
        IQueryable<Visit> GetAllVisits();
        IQueryable<Visit> GetAllVisitsWithDetails();
    }
}
