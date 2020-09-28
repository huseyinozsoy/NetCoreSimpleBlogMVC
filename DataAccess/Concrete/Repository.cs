using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private BlogContext _context;
        private DbSet<T> _dbSet;
        public Repository(BlogContext context)
        {
            _context=context;
            _dbSet = _context.Set<T>();
        }
        public async void Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)  
            { 
                _dbSet.Attach(entity); 
            } 
            _dbSet.Remove(entity); 
        }

        public async void Delete(int id)
        {
            T entityToDelete = await _dbSet.FindAsync(id);
            Delete(entityToDelete);
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> Filter = null)
        {
            if (Filter != null) 
            { 
                return _dbSet.Where(Filter); 
            } 
            return _dbSet;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity); 
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}