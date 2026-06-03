using Bookspace.Domain;

namespace Bookspace.Domain.Exceptions
{
    public class ReviewNotOwnedByReaderException(Review review, Reader reader)
        : InvalidOperationException(
            $"The reader '{reader.Username}' cannot delete the review " +
            $"(review id = {review.Id}) because it does not belong to them.")
    {
        public Review Review => review;
        public Reader Reader => reader;
    }
}