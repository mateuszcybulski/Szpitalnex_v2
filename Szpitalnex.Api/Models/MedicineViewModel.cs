using System;
namespace Szpitalnex.Api.Models
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
