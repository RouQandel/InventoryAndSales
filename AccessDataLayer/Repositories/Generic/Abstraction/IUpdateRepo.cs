namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IUpdateRepo<T> where T : class
{
    Task<T?> UpdateAsync(T entity);
}
