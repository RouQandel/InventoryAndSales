namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IDeteleRepo<T> where T : class
{
    Task<bool> DeleteAsync(long id);
}
