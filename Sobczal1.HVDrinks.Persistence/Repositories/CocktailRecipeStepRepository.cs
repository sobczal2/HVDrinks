using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class CocktailRecipeStepRepository : GenericRepository<CocktailRecipeStep>, ICocktailRecipeStepRepository
{
    private readonly HVDrinksDbContext _dbContext;

    public CocktailRecipeStepRepository(HVDrinksDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}