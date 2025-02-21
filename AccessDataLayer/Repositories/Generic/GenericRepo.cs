using AccessDataLayer.Repositories.Generic.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Linq.Expressions;

namespace AccessDataLayer.Repositories;

public class GenericRepo<T>(AppDbContext dbContext , ILogger<GenericRepo<T>> logger) : IDeteleRepo<T>, IGetbyIdRepo<T>, IGetAllRepo<T>, IAddRepo<T>, IUpdateRepo<T>
    where T : class
{

    private readonly AppDbContext _DbContext = dbContext;
    private readonly ILogger<GenericRepo<T>> _logger = logger ;

    public async Task<T> Add(T entity)
    {
        if (entity is null) return null;
        try
        {
            await _DbContext.Set<T>().AddAsync(entity);
            return entity;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Repo} Add method error", typeof(T));

            return null;
        }
    }

    public void Delete(long id) => _DbContext.Set<T>().Remove(GetById(id).Result);

    public async Task<IReadOnlyList<T>> GetAll
        (Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
    {
        IQueryable<T> query = _DbContext.Set<T>();

        if (filter is not null) query = query.Where(filter);

        if (orderBy != null)
        {
            return await orderBy(query).ToListAsync();
        }
        else
        {
            return await query.AsNoTracking().ToListAsync();
        }
    }

    public async Task<T?> GetById(long id) => await _DbContext.Set<T>().FindAsync(id); 

    public  T Update(T entity) 
    { 
        _DbContext.Set<T>().Update(entity);
               return  entity;
    }

}
