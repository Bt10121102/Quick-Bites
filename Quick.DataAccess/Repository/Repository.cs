//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Quick.DataAccess.Data;
//using Quick.DataAccess.Repository.IRepository;

//namespace Quick.DataAccess.Repository
//{
//    public class Repository<T> : IRepository<T> where T : class
//    {
//        private readonly ApplicationDbContext _db;
//        internal DbSet<T> dbSet;
//        public Repository(ApplicationDbContext db)
//        {
//            _db = db;
//            this.dbSet = _db.Set<T>();
//            //_db.Categories == dbSet
//            _db.Product.Include(u => u.Category).Include(u => u.CategoryId);

//        }

//        public void Add(T entity)
//        {
//            dbSet.Add(entity);
//        }

//        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
//        {
//            IQueryable<T> query = dbSet;
//            query = query.Where(filter);
//            if (!string.IsNullOrEmpty(includeProperties))
//            {
//                foreach (var includeProp in includeProperties
//                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
//                {
//                    query = query.Include(includeProp);
//                }
//            }


//            return query.FirstOrDefault();

//        }

//        public IEnumerable<T> GetAll(string? includeProperties = null)
//        {
//            IQueryable<T> query = dbSet;
//            if (!string.IsNullOrEmpty(includeProperties))
//            {
//                foreach (var includeProp in includeProperties
//                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
//                {
//                    query = query.Include(includeProp);
//                }
//            }
//            return query.ToList();
//        }

//        public void Remove(T entity)
//        {
//            dbSet.Remove(entity);
//        }

//        public void RemoveRange(IEnumerable<T> entity)
//        {
//            dbSet.RemoveRange(entity);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Quick.DataAccess.Data;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;

namespace Quick.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        // Existing methods

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

       
        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            var result = query.FirstOrDefault();

            if (result != null)
            {
                return result;
            }
            else
            {
                // Handle the case where result is null
                // You can log a message, throw an exception, or simply return a default value
                return default(T); // This returns the default value for type T, which is null for reference types
            }
        }
        //the end

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

        // Renamed method to support filtering and include properties
        public IEnumerable<T> GetFiltered(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }
    }
   
}


