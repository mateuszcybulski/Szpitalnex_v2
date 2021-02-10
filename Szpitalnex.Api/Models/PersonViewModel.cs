using System;

namespace Szpitalnex.Api.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public AddressViewModel Address { get; set; }

        public string PersonalNumber { get; set; }
    }
}
