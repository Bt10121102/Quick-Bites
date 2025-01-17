﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Quick.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Existing methods
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

        // Renamed method to support filtering and include properties
        IEnumerable<T> GetFiltered(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
    }
}

