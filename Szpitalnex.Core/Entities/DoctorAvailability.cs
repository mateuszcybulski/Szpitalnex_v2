using System;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class DoctorAvailability : BaseEntity
    {
        public DateTime DateAvailabilityDoctor { get; set; }

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
        public virtual Doctor Doctor { get; set; }
        
        public bool Actual { get; set; }
        public int Room { get; set; }
    }
}
