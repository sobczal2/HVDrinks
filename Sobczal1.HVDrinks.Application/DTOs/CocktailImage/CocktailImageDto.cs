using Sobczal1.HVDrinks.Application.DTOs.Common;

namespace Sobczal1.HVDrinks.Application.DTOs.CocktailImage;

public class CocktailImageDto : BaseAuditableDto
{
    public string Url { get; set; } = null!;
    public string Alt { get; set; } = null!;
}