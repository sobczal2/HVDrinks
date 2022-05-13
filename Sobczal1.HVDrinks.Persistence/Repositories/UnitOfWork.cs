using Microsoft.AspNetCore.Http;
using Sobczal1.HVDrinks.Application.Contracts.Persistence;

namespace Sobczal1.HVDrinks.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly HVDrinksDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ICocktailRepository _cocktailRepository;
    private ICocktailImageRepository _cocktailImageRepository;
    private ICocktailIngredientRepository _cocktailIngredientRepository;
    private ICocktailRecipeStepRepository _cocktailRecipeStepRepository;
    private IIngredientRepository _ingredientRepository;

    public UnitOfWork(HVDrinksDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public ICocktailRepository CocktailRepository => _cocktailRepository ??= new CocktailRepository(_context);

    public ICocktailImageRepository CocktailImageRepository =>
        _cocktailImageRepository ??= new CocktailImageRepository(_context);

    public ICocktailIngredientRepository CocktailIngredientRepository =>
        _cocktailIngredientRepository ??= new CocktailIngredientRepository(_context);

    public ICocktailRecipeStepRepository CocktailRecipeStepRepository =>
        _cocktailRecipeStepRepository ??= new CocktailRecipeStepRepository(_context);

    public IIngredientRepository IngredientRepository => _ingredientRepository ??= new IngredientRepository(_context);

    public async Task Save()
    {
        //TODO fix when identity ready
        var username = "SYSTEM";
        await _context.SaveChangesAsync(username);
    }
}