using System;

namespace Szpitalnex_v0.ViewModels
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        public string Dosage { get; set; }
        public string Form { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Decimal Price { get; set; }
        public string Amount { get; set; }
    }
}
