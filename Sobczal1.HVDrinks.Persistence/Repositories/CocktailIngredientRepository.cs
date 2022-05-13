using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class CocktailIngredientRepository : GenericRepository<CocktailIngredient>, ICocktailIngredientRepository
{
    private readonly HVDrinksDbContext _dbContext;

    public CocktailIngredientRepository(HVDrinksDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}