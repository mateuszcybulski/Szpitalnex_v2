using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories.Base;

namespace Szpitalnex.Database.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        protected override DbSet<Person> DbSet => mDbContext.Persons;

        public PersonRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }


        public IEnumerable<Person> GetAllPersons()
        {
            return DbSet.Include(x => x.Address).Select(x => x);
        }

        IEnumerable<Person> IRepository<Person>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
