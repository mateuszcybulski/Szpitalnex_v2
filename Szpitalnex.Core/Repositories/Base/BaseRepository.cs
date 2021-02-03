using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database
{
    public abstract class BaseRepository<Entity> where Entity : BaseEntity
    {
        protected SzpitalnexContext mDbContext;


        protected abstract DbSet<Entity> DbSet { get; }

        public BaseRepository(SzpitalnexContext dbContext)
        {
            mDbContext = dbContext;
        }

        public Entity Get(int id)
            => DbSet.SingleOrDefault(x => x.Id == id);

        public IQueryable<Entity> GetAll()
            => DbSet;
        /*
        public List<Entity> GetAll()
        {
            var list = new List<Entity>();

            var entityes = DbSet;


            foreach (var entity in entityes)
                list.Add(entity);


            return list;
        }*/

        public bool Add(Entity entity)
        {
            DbSet.Add(entity);

            return SaveChanges();
        }


        public bool Update(Entity entity)
        {
            var foundEntity = DbSet.FirstOrDefault(x => x.Id == entity.Id);

            if (foundEntity != null)
            {

                //foundEntity = entity;
                //DbSet.Update(foundEntity);
                return SaveChanges();
            }

            return false;
        }

        public bool Delete(Entity entity)
        {
            var foundEntity = DbSet.FirstOrDefault(x => x.Id == entity.Id);

            if (foundEntity != null)
            {
                DbSet.Remove(foundEntity);
                return SaveChanges();
            }

            return false;
        }

        public bool SaveChanges()
        {
            return mDbContext.SaveChanges() > 0;
        }

    }
}
