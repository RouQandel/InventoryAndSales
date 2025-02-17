namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IGetbyIdRepo<T> where T : class
{
    Task<T?> GetById(int id);
}
