using Bookspace.Domain;

namespace Bookspace.Domain.Exceptions
{
    public class BookNotFoundException(Guid bookId)
        : InvalidOperationException($"Book with id '{bookId}' was not found.")
    {
        public Guid BookId => bookId;
    }
}