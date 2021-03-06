﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
