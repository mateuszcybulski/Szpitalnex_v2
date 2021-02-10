using System.Collections.Generic;

namespace Szpitalnex.Api.Models
{
    public class DoctorViewModel
    {
        public int Id { get; set; }
        public PersonViewModel Person { get; set; }

        public SpecializationViewModel Specialization { get; set; }

        public List<VisitViewModel> Visits { get; set; }

        public List<SpecializationViewModel> Specializations { get; set; }
    }
}
