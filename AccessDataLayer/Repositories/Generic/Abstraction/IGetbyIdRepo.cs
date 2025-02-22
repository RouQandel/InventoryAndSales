namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IGetbyIdRepo<T>
{
    Task<T?> GetByIdAsync(long id);
}

