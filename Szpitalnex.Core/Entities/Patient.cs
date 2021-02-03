using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Patient : BaseEntity
    {

        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public virtual Person Person { get; set; }

        [NotMapped]
        public virtual List<Visit> Visits { get; set; }
    }
}
