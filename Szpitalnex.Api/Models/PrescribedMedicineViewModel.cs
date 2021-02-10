using System.Collections.Generic;

namespace Szpitalnex.Api.Models
{
    public class PrescribedMedicineViewModel
    {
        public int Id { get; set; }

        public VisitViewModel Visit { get; set; }

        public MedicineViewModel Medicine { get; set; }
        public string Recommendations { get; set; }
    }
}
