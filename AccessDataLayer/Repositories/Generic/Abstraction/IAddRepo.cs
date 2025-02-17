namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IAddRepo<T> where T : class
{
    Task<T> Add(T entity);
}
