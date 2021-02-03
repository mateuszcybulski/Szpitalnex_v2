using System.Collections.Generic;

namespace Szpitalnex.Core.Dto
{
    public class PatientDto
    {
        public int Id { get; set; }

        public PersonDto Person { get; set; }

        public List<VisitDto> Visits { get; set; }
    }
}
