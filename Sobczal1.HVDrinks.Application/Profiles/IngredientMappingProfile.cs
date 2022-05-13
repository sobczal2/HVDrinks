using AutoMapper;
using Sobczal1.HVDrinks.Application.DTOs.Ingredient;
using Sobczal1.HVDrinks.Domain.Ingredients;

namespace Sobczal1.HVDrinks.Application.Profiles;

public class IngredientMappingProfile : Profile
{
    public IngredientMappingProfile()
    {
        CreateMap<Ingredient, ShortIngredientDto>();
    }
}