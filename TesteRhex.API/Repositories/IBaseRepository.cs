using System.Linq.Expressions;

namespace TesteRhexAPI.Repositories;

public interface IBaseRepository<T> where T : class
{
    Task<T?> Get(Expression<Func<T, bool>> predicate);
    Task<T?> GetById(int id);
    Task<IEnumerable<T>?> GetAll();
    Task<T?> Create(T model);
    Task<T?> Update(T model);
    Task<T?> Delete(T model);
}