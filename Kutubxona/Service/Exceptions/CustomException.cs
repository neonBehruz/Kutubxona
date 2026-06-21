namespace Kutubxona.Service.Exceptions;

public class CustomException : FormatException
{
    public int statusCode;

    public CustomException(string? message) : base(message)
    {
    }

    public CustomException(string message, int statusCode) : base(message)
    {
        this.statusCode = statusCode;
    }
};
