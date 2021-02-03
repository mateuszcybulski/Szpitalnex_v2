using System;

namespace Szpitalnex.Core.Dto
{
    public class DoctorAvailabilityDto
    {
        public DateTime DateAvailabilityDoctor { get; set; }
        public int Id { get; set; }
        public DoctorDto Doctor { get; set; }
        public bool Actual { get; set; }
        public int Room { get; set; }
    }
}
