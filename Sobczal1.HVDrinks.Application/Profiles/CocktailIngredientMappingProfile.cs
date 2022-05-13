using AutoMapper;
using Sobczal1.HVDrinks.Application.DTOs.CocktailIngredient;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Application.Profiles;

public class CocktailIngredientMappingProfile : Profile
{
    public CocktailIngredientMappingProfile()
    {
        CreateMap<CocktailIngredient, CocktailIngredientDto>()
            .ForMember(x => x.Ingredient, opt => opt.MapFrom(q => q.Ingredient));
    }
}