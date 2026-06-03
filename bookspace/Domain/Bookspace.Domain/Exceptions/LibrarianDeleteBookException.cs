using BookService.Domain;

namespace BookService.Domain.Exceptions
{
    public class LibrarianDeleteBookException(Librarian librarian, Book book)
        : InvalidOperationException(
            $"The librarian '{librarian.Username}' can't delete the book '{book.Title}' " +
            $"(book id = {book.Id}) because it still has active reviews.")
    {
        public Librarian Librarian => librarian;
        public Book Book => book;
    }
}