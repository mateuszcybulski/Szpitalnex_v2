﻿using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IPrescribedMedicineRepository : IRepository<PrescribedMedicine>
    {
        IEnumerable<PrescribedMedicine> GetAllPrescribedMedicines();
    }
}
