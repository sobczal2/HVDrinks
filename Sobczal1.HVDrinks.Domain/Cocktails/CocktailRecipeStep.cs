using Sobczal1.HVDrinks.Domain.Common;

namespace Sobczal1.HVDrinks.Domain.Cocktails;

public class CocktailRecipeStep : BaseDomainEntity
{
    public int StepNumber { get; set; }
    public string Description { get; set; } = null!;
    public Guid CocktailId { get; set; }
    public virtual Cocktail Cocktail { get; set; }
}