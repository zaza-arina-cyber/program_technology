namespace Domain.ValueObjects.Exceptions
{
    public class InvalidBookStatusException : Exception
    {
        // Конструктор с текущим и ожидаемым статусом
        public InvalidBookStatusException(string currentStatus, string expectedStatus)
            : base($"Неверный статус книги. Текущий: {currentStatus}. Ожидался: {expectedStatus}")
        {
        }

        // Конструктор с произвольным сообщением
        public InvalidBookStatusException(string message)
            : base(message)
        {
        }

        // Конструктор для случая, когда операция недопустима при любом статусе
        public InvalidBookStatusException(Guid bookId, string operation)
            : base($"Операция '{operation}' не может быть выполнена для книги с ID {bookId}")
        {
        }
    }
}
