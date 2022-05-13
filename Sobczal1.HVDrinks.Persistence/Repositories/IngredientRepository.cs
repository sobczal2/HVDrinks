using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Domain.Ingredients;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class IngredientRepository : GenericRepository<Ingredient>, IIngredientRepository
{
    private readonly HVDrinksDbContext _dbContext;

    public IngredientRepository(HVDrinksDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}