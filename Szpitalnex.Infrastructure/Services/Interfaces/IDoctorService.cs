using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;

namespace Szpitalnex.Infrastructure.Interfaces
{
    public interface IDoctorService
    {
        DoctorDto Get(int id);
    }
}
