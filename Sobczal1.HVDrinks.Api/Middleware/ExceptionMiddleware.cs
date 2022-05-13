using System.Net;
using Newtonsoft.Json;
using Sobczal1.HVDrinks.Application.Exceptions;

namespace Sobczal1.HVDrinks.Api.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception exeption)
        {
            await HandleExceptionAsync(httpContext, exeption);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        var result = JsonConvert.SerializeObject(new ErrorDeatils("Failure", exception.Message));
        if (exception is ApplicationErrorException)
        {
            statusCode = ((ApplicationErrorException) exception).Code;
            result = JsonConvert.SerializeObject(((ApplicationErrorException) exception).Errors);
        }

        context.Response.StatusCode = (int) statusCode;
        return context.Response.WriteAsync(result);
    }
    
    public class ErrorDeatils
    {
        public ErrorDeatils(string errorType, string errorMessage)
        {
            ErrorType = errorType;
            ErrorMessage = errorMessage;
        }

        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }
}