using Sobczal1.HVDrinks.Domain.Common;

namespace Sobczal1.HVDrinks.Domain.Cocktails;

public class Cocktail : BaseDomainEntity
{
    public Cocktail()
    {
        CocktailIngredients = new HashSet<CocktailIngredient>();
        CocktailImages = new HashSet<CocktailImage>();
    }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Popularity { get; set; }
    public virtual ICollection<CocktailRecipeStep> RecipeSteps { get; set; }
    public virtual ICollection<CocktailIngredient> CocktailIngredients { get; set; }
    public virtual ICollection<CocktailImage> CocktailImages { get; set; }
}