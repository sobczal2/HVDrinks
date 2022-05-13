using Microsoft.EntityFrameworkCore;
using Sobczal1.HVDrinks.Domain.Cocktails;
using Sobczal1.HVDrinks.Domain.Ingredients;

namespace Sobczal1.HVDrinks.Persistence;

public class HVDrinksDbContext : AuditableDbContext
{
    public HVDrinksDbContext()
    {
        
    }
    public HVDrinksDbContext(DbContextOptions<HVDrinksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HVDrinksDbContext).Assembly);
    }

    public DbSet<Cocktail> Cocktails { get; set; }
    public DbSet<CocktailImage> CocktailImages { get; set; }
    public DbSet<CocktailIngredient> CocktailIngredients { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
}