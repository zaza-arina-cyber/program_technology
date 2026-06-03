namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class InvalidReviewTextException(string text, string message)
        : ArgumentException($"Invalid review text: {message}")
    {
        public string Text => text;
    }
}