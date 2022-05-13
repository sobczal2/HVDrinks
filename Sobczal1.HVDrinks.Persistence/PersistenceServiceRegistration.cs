using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Persistence.Repositories;

namespace Sobczal1.HVDrinks.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
        IConfiguration cfg)
    {
        services.AddDbContext<HVDrinksDbContext>(opt =>
        {
            opt.UseSqlServer(cfg.GetConnectionString("HVDrinksConnectionString"));
            opt.LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
            opt.EnableSensitiveDataLogging();
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<ICocktailRepository, CocktailRepository>();
        services.AddScoped<ICocktailImageRepository, CocktailImageRepository>();
        services.AddScoped<ICocktailIngredientRepository, CocktailIngredientRepository>();
        services.AddScoped<ICocktailRecipeStepRepository, CocktailRecipeStepRepository>();
        services.AddScoped<IIngredientRepository, IngredientRepository>();

        return services;
    }
}