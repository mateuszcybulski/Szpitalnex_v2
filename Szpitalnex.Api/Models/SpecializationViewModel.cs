using System.Collections.Generic;

namespace Szpitalnex_v0.ViewModels
{
    public class SpecializationViewModel
    {
        public int Id { get; set; }
        public string NameSpecialization { get; set; }
        public IEnumerable<ReferralViewModel> Referrals { get; set; }
    }
}
