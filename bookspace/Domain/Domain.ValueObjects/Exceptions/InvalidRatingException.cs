namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class InvalidRatingException(int rating, string message)
        : ArgumentException($"Invalid rating '{rating}': {message}")
    {
        public int Rating => rating;
    }
}
