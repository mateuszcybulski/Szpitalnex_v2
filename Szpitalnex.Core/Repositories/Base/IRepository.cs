﻿using System.Collections.Generic;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Repositories.Base
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        Entity Get(int id);
        IEnumerable<Entity> GetAll();
        bool Add(Entity entity);
        bool Update(Entity entity);
        bool Delete(Entity entity);

    }
}
