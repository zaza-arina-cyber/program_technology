namespace Domain.ValueObjects.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(Guid bookId)
            : base($"Книга с ID {bookId} не найдена")
        {
        }

        public BookNotFoundException(string message)
            : base(message)
        {
        }
    }
}