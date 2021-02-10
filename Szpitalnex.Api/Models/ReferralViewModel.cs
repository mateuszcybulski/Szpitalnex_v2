using System.Collections.Generic;

namespace Szpitalnex_v0.ViewModels
{
    public class ReferralViewModel
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public SpecializationViewModel Specialization { get; set; }
        public List<SpecializationViewModel> Specializations { get; set; }
    }
}
