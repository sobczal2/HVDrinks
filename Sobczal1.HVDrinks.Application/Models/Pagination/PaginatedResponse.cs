using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sobczal1.HVDrinks.Application.Exceptions;

namespace Sobczal1.HVDrinks.Application.Models.Pagination;

public class PaginatedResponse<T> : List<T>
{
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public int TotalResults { get; set; }
    public int TotalPages { get; set; }

    private PaginatedResponse(IEnumerable<T> items, int currentPage, int pageSize, int totalCount)
    {
        PageSize = pageSize;
        CurrentPage = currentPage;
        TotalResults = totalCount;
        TotalPages = (int) Math.Ceiling(TotalResults / (double) PageSize);
        AddRange(items);
    }

    public static async Task<PaginatedResponse<T>> CreateAsync(IQueryable<T> source,
        PaginatedRequestData paginatedRequestData, Expression<Func<T, object>> order)
    {
        var validator = new PaginatedRequestDataValidator();
        var validationResult = await validator.ValidateAsync(paginatedRequestData);

        if (!validationResult.IsValid)
            throw new ValidationErrorsException(validationResult);
        
        var totalCount = await source.CountAsync();
        var items = await source.OrderBy(order).Skip((paginatedRequestData.CurrentPage!.Value - 1) * paginatedRequestData.PageSize!.Value)
            .Take(paginatedRequestData.PageSize.Value).ToListAsync();
        return new PaginatedResponse<T>(items, paginatedRequestData.CurrentPage.Value, paginatedRequestData.PageSize.Value, totalCount);
    }
}