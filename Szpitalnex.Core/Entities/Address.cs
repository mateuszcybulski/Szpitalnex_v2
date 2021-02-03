using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
