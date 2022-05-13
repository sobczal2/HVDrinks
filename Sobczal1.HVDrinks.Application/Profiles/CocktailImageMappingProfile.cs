using AutoMapper;
using Sobczal1.HVDrinks.Application.DTOs.CocktailImage;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Application.Profiles;

public class CocktailImageMappingProfile : Profile
{
    public CocktailImageMappingProfile()
    {
        CreateMap<CocktailImage, CocktailImageDto>();
    }
}