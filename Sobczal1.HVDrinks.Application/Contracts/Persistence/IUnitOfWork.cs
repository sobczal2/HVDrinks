namespace Sobczal1.HVDrinks.Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    ICocktailRepository CocktailRepository { get; }
    ICocktailImageRepository CocktailImageRepository { get; }
    ICocktailIngredientRepository CocktailIngredientRepository { get; }
    ICocktailRecipeStepRepository CocktailRecipeStepRepository { get; }
    IIngredientRepository IngredientRepository { get; }
    Task Save();
}