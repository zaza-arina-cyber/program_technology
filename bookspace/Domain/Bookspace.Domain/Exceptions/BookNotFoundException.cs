using BookService.Domain;

namespace BookService.Domain.Exceptions
{
    public class BookNotFoundException(Guid bookId)
        : InvalidOperationException($"Book with id '{bookId}' was not found.")
    {
        public Guid BookId => bookId;
    }
}