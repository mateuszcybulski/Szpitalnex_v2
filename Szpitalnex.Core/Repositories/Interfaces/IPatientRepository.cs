using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        IEnumerable<Patient> GetAllPatients();
    }
}
