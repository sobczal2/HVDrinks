using Sobczal1.HVDrinks.Application.DTOs.Common;

namespace Sobczal1.HVDrinks.Application.DTOs.Ingredient;

public class ShortIngredientDto : BaseAuditableDto
{
    public string Name { get; set; } = null!;
    public double AlcoholContent { get; set; }
}