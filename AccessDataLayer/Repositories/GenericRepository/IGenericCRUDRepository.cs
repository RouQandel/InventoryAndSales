using System.Linq.Expressions;

namespace AccessDataLayer.Repositories;

public interface IGenericRepository <T> where T : class
{
   
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> Add(T entity);
        T Update(T entity);
        void Delete(int id);       
        Task SaveChangesAsync();
    }

