using System.Collections.Generic;

namespace Szpitalnex_v0.ViewModels
{
    public class PrescribedMedicineViewModel
    {
        public int Id { get; set; }

        public VisitViewModel Visit { get; set; }

        public MedicineViewModel Medicine { get; set; }
        public string Recommendations { get; set; }
    }
}
