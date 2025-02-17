namespace AccessDataLayer.Repositories.Generic.Abstraction;

public interface IDeteleRepo<T> where T : class
{
    void Delete(int id);
}
