namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class InvalidTitleException(string title, string message)
        : ArgumentException($"Invalid title '{title}': {message}")
    {
        public string Title => title;
    }
}