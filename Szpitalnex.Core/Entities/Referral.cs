using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Referral : BaseEntity
    {
        public string Purpose { get; set; }

        [ForeignKey("Specialization")]
        public int IdSpecialization { get; set; }
        public virtual Specialization Specialization { get; set; }

        [ForeignKey("Visit")]
        public int? IdVisit { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
