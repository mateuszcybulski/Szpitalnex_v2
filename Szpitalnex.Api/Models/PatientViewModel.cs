using System;
using System.Collections.Generic;

namespace Szpitalnex_v0.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        public PersonViewModel Person { get; set; }

        public IEnumerable<VisitViewModel> Visits { get; set; }
    }
}
