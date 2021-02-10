namespace Szpitalnex.Api.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
