using Domain.bookspace.ValueObjects;

namespace Domain.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid ReviewerId { get; set; }   // ID читателя, который оставил отзыв
        public Rating Rating { get; set; }
        public string Text { get; set; }

        // Конструктор
        public Review(Guid id, Guid bookId, Guid reviewerId, Rating rating, string text)
        {
            Id = id;
            BookId = bookId;
            ReviewerId = reviewerId;
            Rating = rating;
            Text = text;
        }

        // === НУЖНЫЕ МЕТОДЫ ===

        // Проверка, может ли библиотекарь удалить этот отзыв (некорректный)
        public bool IsCorrupted()
        {
            return string.IsNullOrWhiteSpace(Text) || Rating.Value < 1 || Rating.Value > 5;
        }
    }
}
