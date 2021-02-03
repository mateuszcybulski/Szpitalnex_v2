using System;
using System.Collections.Generic;

namespace Szpitalnex.Core.Dto
{
    public class VisitDto
    {
        public int Id { get; set; }
        public DoctorDto Doctor { get; set; }

        public PatientDto Patient { get; set; }

        public DateTime VisitDate { get; set; }
        public string Note { get; set; }
        public int ConsultingRoom { get; set; }

        public List<PrescribedMedicineDto> PrescribedMedicines { get; set; }

        public List<ReferralDto> Referral { get; set; }
        public List<DiagnosedDiseaseDto> DiagnosedDiseases { get; set; }

    }
}
