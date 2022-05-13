using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class CocktailRepository : GenericRepository<Cocktail>, ICocktailRepository
{
    private readonly HVDrinksDbContext _dbContext;

    public CocktailRepository(HVDrinksDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}