using EF.First.Project.DAL.Contex;
using EF.First.Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Repositories
{
    class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal Model1 context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(Model1 context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query;
        }

        public TEntity Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate)
        {
            return dbSet.Where(predicate);
        }

        public void Delete(int id)
        {
            TEntity entity = dbSet.Find(id);

            if (entity != null)
                dbSet.Remove(entity);

            context.SaveChanges();
        }
    }
}
