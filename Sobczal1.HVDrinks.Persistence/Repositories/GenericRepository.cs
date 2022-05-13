using Microsoft.EntityFrameworkCore;
using Sobczal1.HVDrinks.Application.Contracts.Persistence;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly HVDrinksDbContext _dbContext;

    public GenericRepository(HVDrinksDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T?> Get(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IQueryable<T>> GetAll()
    {
        return _dbContext.Set<T>();
    }

    public async Task<T> Add(T entity)
    {
        await _dbContext.AddAsync(entity);
        return entity;
    }

    public async Task<bool> Exists(Guid id)
    {
        var entity = await Get(id);
        return entity != null;
    }

    public async Task Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public async Task Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }
}