﻿using System.Linq;

namespace MeuPatrimonio.Infra.Data.Interfaces
{
    public interface IDatasourceContext
    {
        void Add<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;
    }
}
