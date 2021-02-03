using System;
using System.ComponentModel.DataAnnotations.Schema;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Person : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

        [ForeignKey("Address")]
        public int IdAddress { get; set; }
        public virtual Address Address { get; set; }

        public string PersonalNumber { get; set; }
    }
}
