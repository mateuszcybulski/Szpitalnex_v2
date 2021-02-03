using System.Collections.Generic;

namespace Szpitalnex.Core.Dto
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public PersonDto Person { get; set; }

        public SpecializationDto Specialization { get; set; }

        public List<VisitDto> Visits { get; set; }

        public List<SpecializationDto> Specializations { get; set; }
    }
}
