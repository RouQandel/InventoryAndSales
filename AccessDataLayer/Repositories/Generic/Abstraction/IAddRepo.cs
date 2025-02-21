namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IAddRepo<T> where T : class
{
    Task<T?> AddAsync(T entity);
}
