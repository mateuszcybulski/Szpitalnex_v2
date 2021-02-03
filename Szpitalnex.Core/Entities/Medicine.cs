using System;
using System.ComponentModel.DataAnnotations;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Medicine : BaseEntity
    {
        public string Dosage { get; set; }
        public string Form { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Decimal Price { get; set; }
        public string Amount { get; set; }
    }
}
