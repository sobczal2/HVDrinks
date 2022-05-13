using AutoMapper;
using Sobczal1.HVDrinks.Application.DTOs.CocktailRecipeStep;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Application.Profiles;

public class CocktailRecipeStepMappingProfile : Profile
{
    public CocktailRecipeStepMappingProfile()
    {
        CreateMap<CocktailRecipeStep, CocktailRecipeStepDto>();
    }
}