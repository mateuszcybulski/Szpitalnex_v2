using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Visit : BaseEntity
    {

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
        public virtual Doctor Doctor { get; set; }

        [ForeignKey("Patient")]
        public int? IdPatient { get; set; }
        public virtual Patient Patient { get; set; }

        public DateTime VisitDate { get; set; }
        public string Note { get; set; }
        public int ConsultingRoom { get; set; }


        [NotMapped]
        public virtual List<PrescribedMedicine> PrescribedMedicines { get; set; }

        [NotMapped]
        public virtual List<Referral> Referral { get; set; }

        [NotMapped]
        public virtual List<DiagnosedDisease> DiagnosedDiseases { get; set; }

    }
}
