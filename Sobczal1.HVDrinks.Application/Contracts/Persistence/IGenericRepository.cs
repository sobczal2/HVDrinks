namespace Sobczal1.HVDrinks.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T?> Get(Guid id);
    Task<IQueryable<T>> GetAll();
    Task<T> Add(T entity);
    Task<bool> Exists(Guid id);
    Task Update(T entity);
    Task Delete(T entity);
}