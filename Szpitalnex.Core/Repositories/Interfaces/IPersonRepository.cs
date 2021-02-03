using System.Collections.Generic;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Database.Repositories.Base.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        IEnumerable<Person> GetAllPersons();
    }
}
