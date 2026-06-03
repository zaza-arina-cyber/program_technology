namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class InvalidAuthorException(string author, string message)
        : ArgumentException($"Invalid author '{author}': {message}")
    {
        public string Author => author;
    }
}