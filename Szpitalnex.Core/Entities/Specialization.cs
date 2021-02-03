using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Specialization : BaseEntity
    {
        public string NameSpecialization { get; set; }

        [NotMapped]
        public virtual List<Referral> Referrals { get; set; }

    }
}
