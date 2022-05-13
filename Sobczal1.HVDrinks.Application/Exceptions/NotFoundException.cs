using System.Net;

namespace Sobczal1.HVDrinks.Application.Exceptions;

public class NotFoundException : ApplicationErrorException
{
    public NotFoundException(string key, string value) : base(new Dictionary<string, string>{{key, value}}, HttpStatusCode.NotFound)
    {
    }
}