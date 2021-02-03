using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Doctor : BaseEntity
    {

        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public virtual Person Person { get; set; }

        [ForeignKey("Specialization")]
        public int IdSpecialization { get; set; }
        public virtual Specialization Specialization { get; set; }

        [NotMapped]
        public virtual List<Visit> Visits { get; set; }

        [NotMapped]
        public virtual List<Specialization> Specializations { get; set; }
    }
}
