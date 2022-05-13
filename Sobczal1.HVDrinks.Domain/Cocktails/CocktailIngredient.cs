using Sobczal1.HVDrinks.Domain.Common;
using Sobczal1.HVDrinks.Domain.Ingredients;

namespace Sobczal1.HVDrinks.Domain.Cocktails;

public class CocktailIngredient : BaseDomainEntity
{
    public Guid CocktailId { get; set; }
    public virtual Cocktail Cocktail { get; set; } = null!;
    public Guid IngredientId { get; set; }
    public virtual Ingredient Ingredient { get; set; } = null!;
    public double Amount { get; set; }
}