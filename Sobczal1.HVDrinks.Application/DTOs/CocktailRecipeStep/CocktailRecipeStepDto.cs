using Sobczal1.HVDrinks.Application.DTOs.Common;

namespace Sobczal1.HVDrinks.Application.DTOs.CocktailRecipeStep;

public class CocktailRecipeStepDto : BaseAuditableDto
{
    public int StepNumber { get; set; }
    public string Description { get; set; } = null!;
}