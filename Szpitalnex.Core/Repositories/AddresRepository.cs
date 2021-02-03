using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities;
using Szpitalnex.Database.Entities.Base;
using Szpitalnex.Database.Repositories.Base;
using Szpitalnex.Database.Repositories.Base.Interfaces;

namespace Szpitalnex.Database.Repositories
{
    public class AddresRepository : BaseRepository<Address>, IAddressRepository
    {
        protected override DbSet<Address> DbSet => mDbContext.Addresses;

        public AddresRepository(SzpitalnexContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Address> GetAllAddresses()
        {
            return DbSet.Select(x => x);
        }

    }
}
