using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetAllDoctors();
    }
}
