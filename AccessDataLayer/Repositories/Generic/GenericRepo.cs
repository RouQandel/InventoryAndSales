using AccessDataLayer.Repositories.Generic.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Linq.Expressions;

namespace AccessDataLayer.Repositories;

public class GenericRepo<T> : IDeteleRepo<T>, IGetbyIdRepo<T>, IGetAllRepo<T>, IAddRepo<T>, IUpdateRepo<T>, ISaveRepo<T>
    where T : class
{
    private readonly AppDbContext _dbContext;


    public GenericRepo(AppDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
 
    }

    public async Task<T?> AddAsync(T entity)
    {
        if (entity is null) throw new ArgumentNullException(nameof(entity));

        try
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }
        catch (Exception)
        {
            throw;
        }

	}

	public async Task<bool> DeleteAsync(long id)
    {
        var entity = await GetByIdAsync(id);
        if (entity == null) return false;

        _dbContext.Set<T>().Remove(entity);
        return true;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        if (filter is not null)
            query = query.Where(filter);

        return orderBy != null
            ? await orderBy(query).ToListAsync()
            : await query.AsNoTracking().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(long id) => await _dbContext.Set<T>().FindAsync(id);

    public async Task SaveChangesAsync() => await _dbContext.SaveChangesAsync();


    public async Task<T?> UpdateAsync(T entity)
    {
        if (entity is null) return null;

        try
        {
            _dbContext.Set<T>().Update(entity);
            return entity;
        }
		catch (Exception)
		{
			
			throw;

			
        }
    }
}
