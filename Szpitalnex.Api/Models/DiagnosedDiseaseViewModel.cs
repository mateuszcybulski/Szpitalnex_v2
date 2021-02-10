using System;
using System.Collections.Generic;

namespace Szpitalnex_v0.ViewModels
{
    public class DiagnosedDiseaseViewModel
    {
        public int Id { get; set; }
        public VisitViewModel Visit { get; set; }
        public DiseaseViewModel Disease { get; set; }
    }
}
