using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class PrescribedMedicine : BaseEntity
    {

        [ForeignKey("Visit")]
        public int IdVisit { get; set; }
        public virtual Visit Visit { get; set; }

        [ForeignKey("Medicine")]
        public int IdMedicine { get; set; }
        public virtual Medicine Medicine { get; set; }
        public string Recommendations { get; set; }
    }
}
