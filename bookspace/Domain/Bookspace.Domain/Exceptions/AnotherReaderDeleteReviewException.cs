using BookService.Domain;

namespace BookService.Domain.Exceptions
{
    public class AnotherReaderDeleteReviewException(Review review, Reader reader)
        : InvalidOperationException(
            $"The reader '{reader.Username}' can't delete the review " +
            $"(review id = {review.Id}) because it doesn't belong to them.")
    {
        public Review Review => review;
        public Reader Reader => reader;
    }
}