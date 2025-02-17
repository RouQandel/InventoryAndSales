using System.Linq.Expressions;

namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IGenericRepo<T> where T : class
{
    Task<int> Count();
    Task<IEnumerable<T>> GetWith(string[]? includes = null, Expression<Func<T, bool>>? filter = null);
    Task<int> CountWhere(Expression<Func<T, bool>>? filter = null);
}
