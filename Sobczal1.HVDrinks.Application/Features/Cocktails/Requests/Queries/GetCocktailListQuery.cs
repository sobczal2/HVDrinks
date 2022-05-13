using MediatR;
using Sobczal1.HVDrinks.Application.DTOs.Cocktail;
using Sobczal1.HVDrinks.Application.Models.Pagination;

namespace Sobczal1.HVDrinks.Application.Features.Cocktails.Requests.Queries;

public class GetCocktailListQuery : IRequest<PaginatedResponse<ShortCocktailDto>>
{
    public PaginatedRequestData PaginatedRequestData { get; set; }
}