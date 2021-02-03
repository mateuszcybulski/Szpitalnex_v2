using System.Collections.Generic;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories.Interfaces
{
    public interface IDoctorAvailabilityRepository : IRepository<DoctorAvailability>
    {
        IEnumerable<DoctorAvailability> GetAllDoctorAvailabilityTrue();
        IEnumerable<DoctorAvailability> GetAllDoctorAvailabilityFalse();
    }
}
