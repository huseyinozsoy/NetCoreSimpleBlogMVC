using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        Task<T> GetById(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> Filter = null);
    }
}