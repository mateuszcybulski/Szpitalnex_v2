using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class DiagnosedDisease : BaseEntity
    {

        [ForeignKey("Visit")]
        public int IdVisit { get; set; }
        public virtual Visit Visit { get; set; }

        [ForeignKey("Disease")]
        public int IdDisease { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
