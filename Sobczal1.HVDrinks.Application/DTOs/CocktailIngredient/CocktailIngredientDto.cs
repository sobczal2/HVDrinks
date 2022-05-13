using Sobczal1.HVDrinks.Application.DTOs.Common;
using Sobczal1.HVDrinks.Application.DTOs.Ingredient;

namespace Sobczal1.HVDrinks.Application.DTOs.CocktailIngredient;

public class CocktailIngredientDto : BaseAuditableDto
{
    public ShortIngredientDto Ingredient { get; set; } = null!;
    public double Amount { get; set; }
}