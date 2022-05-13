using Sobczal1.HVDrinks.Domain.Common;

namespace Sobczal1.HVDrinks.Domain.Cocktails;

public class CocktailImage : BaseDomainEntity
{
    public string Url { get; set; } = null!;
    public string Alt { get; set; } = null!;
    public bool Main { get; set; }
    public Guid CocktailId { get; set; }
    public virtual Cocktail Cocktail { get; set; } = null!;
}