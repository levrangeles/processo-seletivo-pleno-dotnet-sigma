﻿using System;
using System.Collections.Generic;

namespace MeuPatrimonio.Domain.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Remove(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> filter = null);
    }
}
