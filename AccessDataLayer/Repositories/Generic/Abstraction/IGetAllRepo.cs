using System.Linq.Expressions;

namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IGetAllRepo<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync(
          Expression<Func<T, bool>>? filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null);

}
