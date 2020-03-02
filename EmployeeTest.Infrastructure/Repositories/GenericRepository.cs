using EmployeeTest.Core.Interfaces;
using EmployeeTest.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
            => await _dbSet.ToListAsync();
        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate) => await _dbSet.FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate) => await _dbSet.Where(predicate).ToListAsync();


        public async Task<T> GetById(Guid id)
            => await _dbSet.FindAsync(id);

        public void Insert(T entity)
            => _dbSet.Add(entity);

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual IQueryable<T> IncludeAll()
        {
            var query = _context.Set<T>().AsQueryable();
            foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                query = query.Include(property.Name);
            return query;
        }


        public void DeleteById(Guid id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }
        public void Delete(T entity)
            => _dbSet.Remove(entity);


        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
