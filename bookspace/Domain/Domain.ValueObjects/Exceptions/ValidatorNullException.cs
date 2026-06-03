namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class ValidatorNullException(string paramName)
        : ArgumentNullException(paramName)
    {
    }
}