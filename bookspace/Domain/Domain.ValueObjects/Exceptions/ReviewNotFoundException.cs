using System;

namespace Domain.Exceptions
{
    public class ReviewNotFoundException : Exception
    {
        public ReviewNotFoundException(Guid reviewId)
            : base($"Отзыв с ID {reviewId} не найден")
        {
        }

        public ReviewNotFoundException(string message)
            : base(message)
        {
        }
    }
}