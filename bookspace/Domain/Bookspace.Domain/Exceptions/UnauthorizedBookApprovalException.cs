using Bookspace.Domain;

namespace Bookspace.Domain.Exceptions
{
    public class UnauthorizedBookApprovalException(Reader reader, Book book)
        : InvalidOperationException(
            $"Reader '{reader.Username}' is not authorized to approve or reject " +
            $"the book '{book.Title}' (book id = {book.Id}).")
    {
        public Reader Reader => reader;
        public Book Book => book;
    }
}