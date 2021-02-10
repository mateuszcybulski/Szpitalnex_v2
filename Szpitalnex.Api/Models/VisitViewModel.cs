using System;
using System.Collections.Generic;
using System.Text;

namespace Szpitalnex.Api.Models
{
    public class VisitViewModel
    {
        public int Id { get; set; }
        public DoctorViewModel Doctor { get; set; }

        public PatientViewModel Patient { get; set; }

        public DateTime VisitDate { get; set; }
        public string Note { get; set; }
        public int ConsultingRoom { get; set; }

        public IEnumerable<PrescribedMedicineViewModel> PrescribedMedicines { get; set; }

        public IEnumerable<ReferralViewModel> Referral { get; set; }
        public IEnumerable<DiagnosedDiseaseViewModel> DiagnosedDiseases { get; set; }
        
    }
}
