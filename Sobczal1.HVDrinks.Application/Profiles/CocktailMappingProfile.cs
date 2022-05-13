using AutoMapper;
using Sobczal1.HVDrinks.Application.DTOs.Cocktail;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Application.Profiles;

public class CocktailMappingProfile : Profile
{
    public CocktailMappingProfile()
    {
        CreateMap<Cocktail, ShortCocktailDto>()
            .ForMember(x => x.MainImage,
                opt =>
                {
                    opt.MapFrom(q => q.CocktailImages.FirstOrDefault(ci => ci.Main));
                });
    }
}