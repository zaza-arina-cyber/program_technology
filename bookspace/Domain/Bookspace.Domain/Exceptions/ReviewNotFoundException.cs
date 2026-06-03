namespace Bookspace.Domain.Exceptions
{
    public class ReviewNotFoundException(Guid reviewId)
        : InvalidOperationException($"Review with id '{reviewId}' was not found.")
    {
        public Guid ReviewId => reviewId;
    }
}