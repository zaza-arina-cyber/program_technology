namespace Domain.ValueObjects.Exceptions
{
    public class InvalidRatingException : Exception
    {
        // Конструктор с указанием недопустимого значения
        public InvalidRatingException(int rating)
            : base($"Рейтинг {rating} недопустим. Допустимые значения: от 1 до 5")
        {
        }

        // Конструктор с произвольным сообщением
        public InvalidRatingException(string message)
            : base(message)
        {
        }
    }
}
