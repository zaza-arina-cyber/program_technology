using System;

namespace Domain.ValueObjects.Exceptions
{
    public class ReviewNotOwnedByReaderException : Exception
    {
        // Конструктор с ID читателя и отзыва
        public ReviewNotOwnedByReaderException(Guid readerId, Guid reviewId)
            : base($"Читатель с ID {readerId} не является автором отзыва с ID {reviewId}")
        {
        }

        // Конструктор с произвольным сообщением
        public ReviewNotOwnedByReaderException(string message)
            : base(message)
        {
        }
    }
}
