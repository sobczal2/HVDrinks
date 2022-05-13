using Sobczal1.HVDrinks.Domain.Cocktails;
using Sobczal1.HVDrinks.Domain.Common;

namespace Sobczal1.HVDrinks.Domain.Ingredients;

public class Ingredient : BaseDomainEntity
{
    public Ingredient()
    {
        CocktailIngredients = new HashSet<CocktailIngredient>();
    }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double AlcoholContent { get; set; }
    public IngredientUnit Unit { get; set; }
    public virtual ICollection<CocktailIngredient> CocktailIngredients { get; set; }
}