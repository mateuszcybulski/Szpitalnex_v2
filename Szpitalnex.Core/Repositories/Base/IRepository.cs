using System.Collections.Generic;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Repositories.Base
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        bool Add(Entity entity);
        //IEnumerable<BaseEntity> GetAll();
        bool Update(Entity entity);
        bool Delete(Entity entity);

    }
}
