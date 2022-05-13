using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class CocktailImageRepository : GenericRepository<CocktailImage>, ICocktailImageRepository
{
    private readonly HVDrinksDbContext _dbContext;

    public CocktailImageRepository(HVDrinksDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}