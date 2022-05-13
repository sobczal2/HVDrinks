using System.Net;

namespace Sobczal1.HVDrinks.Application.Exceptions;

public class BadRequestException : ApplicationErrorException
{
    public BadRequestException(Dictionary<string, string> errors) : base(errors, HttpStatusCode.BadRequest)
    {
    }
}