using System;
using System.Collections.Generic;

namespace Szpitalnex.Api.Models
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        public PersonViewModel Person { get; set; }

        public IEnumerable<VisitViewModel> Visits { get; set; }
    }
}
