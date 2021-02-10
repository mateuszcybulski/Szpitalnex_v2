using System;

namespace Szpitalnex.Api.Models
{
    public class DoctorAvailabilityViewModel
    {
        public DateTime DateAvailabilityDoctor { get; set; }
        public int Id { get; set; }
        public DoctorViewModel Doctor { get; set; }
        public bool Actual { get; set; }
        public int Room { get; set; }
    }
}
