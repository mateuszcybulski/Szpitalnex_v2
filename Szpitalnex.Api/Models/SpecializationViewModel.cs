using System.Collections.Generic;

namespace Szpitalnex.Api.Models
{
    public class SpecializationViewModel
    {
        public int Id { get; set; }
        public string NameSpecialization { get; set; }
        public IEnumerable<ReferralViewModel> Referrals { get; set; }
    }
}
