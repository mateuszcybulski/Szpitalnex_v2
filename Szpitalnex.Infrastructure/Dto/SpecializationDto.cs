using System.Collections.Generic;

namespace Szpitalnex.Core.Dto
{
    public class SpecializationDto
    {
        public int Id { get; set; }
        public string NameSpecialization { get; set; }
        public List<ReferralDto> Referrals { get; set; }

    }
}
