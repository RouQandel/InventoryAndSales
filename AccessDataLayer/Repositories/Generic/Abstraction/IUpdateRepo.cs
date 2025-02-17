namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IUpdateRepo<T> where T : class
{
    T Update(T entity);
}
