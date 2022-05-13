using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sobczal1.HVDrinks.Application.DTOs.Cocktail;
using Sobczal1.HVDrinks.Application.Models.Pagination;

namespace Sobczal1.HVDrinks.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CocktailsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CocktailsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<PaginatedResponse<ShortCocktailDto>>> List(
        [FromQuery] PaginatedRequestData paginatedRequestData)
    {
        var cocktails =
            await _mediator.Send(
                new Sobczal1.HVDrinks.Application.Features.Cocktails.Requests.Queries.GetCocktailListQuery{PaginatedRequestData = paginatedRequestData});
        return Ok(cocktails);
    }
}