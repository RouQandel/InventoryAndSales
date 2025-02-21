namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface ISaveRepo<T> where T : class
{
    Task SaveChangesAsync();
}
