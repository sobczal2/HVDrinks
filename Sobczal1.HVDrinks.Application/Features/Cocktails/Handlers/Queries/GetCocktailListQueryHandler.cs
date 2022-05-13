using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Sobczal1.HVDrinks.Application.Contracts.Persistence;
using Sobczal1.HVDrinks.Application.DTOs.Cocktail;
using Sobczal1.HVDrinks.Application.Features.Cocktails.Requests.Queries;
using Sobczal1.HVDrinks.Application.Models.Pagination;

namespace Sobczal1.HVDrinks.Application.Features.Cocktails.Handlers.Queries;

public class
    GetCocktailListQueryHandler : IRequestHandler<GetCocktailListQuery, PaginatedResponse<ShortCocktailDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCocktailListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginatedResponse<ShortCocktailDto>> Handle(GetCocktailListQuery query,
        CancellationToken cancellationToken)
    {
        var cocktails = await _unitOfWork.CocktailRepository.GetAll();
        return await PaginatedResponse<ShortCocktailDto>.CreateAsync(
            cocktails.ProjectTo<ShortCocktailDto>(_mapper.ConfigurationProvider),
            query.PaginatedRequestData, q => q.Popularity);
    }
}