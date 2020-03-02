using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Core.Interfaces
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);
        Task<T> GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(Guid guid);
        IQueryable<T> IncludeAll();

    }
}
