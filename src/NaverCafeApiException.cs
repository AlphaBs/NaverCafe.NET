namespace NaverCafeClient;

public class NaverCafeApiException : Exception
{
    private static string CreateExceptionMessage(string? code, string? message)
    {
        if (!string.IsNullOrEmpty(message))
            return message;
        if (!string.IsNullOrEmpty(code))
            return $"error code: {code}";
        
        return "The api endpoint returned error.";
    }

    public NaverCafeApiException() : this(null, null)
    {

    }

    public NaverCafeApiException(string? code, string? message) : 
        base(CreateExceptionMessage(code, message))
    {
        Code = code;
    }

    public string? Code { get; }
}