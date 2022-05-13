using Sobczal1.HVDrinks.Application.DTOs.CocktailImage;
using Sobczal1.HVDrinks.Application.DTOs.CocktailIngredient;
using Sobczal1.HVDrinks.Application.DTOs.Common;

namespace Sobczal1.HVDrinks.Application.DTOs.Cocktail;

public class ShortCocktailDto : BaseAuditableDto
{
    public ShortCocktailDto()
    {
        CocktailIngredients = new List<CocktailIngredientDto>();
    }
    public string Name { get; set; } = null!;
    public int Popularity { get; set; }
    public CocktailImageDto? MainImage { get; set; }
    public List<CocktailIngredientDto> CocktailIngredients { get; set; }
}