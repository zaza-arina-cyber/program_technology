using BookService.Domain.Base;

namespace BookService.Domain
{
    public class Review : Entity<Guid>
    {
        public Guid BookId { get; set; }
        public Guid ReviewerId { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }

        public Review(Guid id, Guid bookId, Guid reviewerId, int rating, string text) : base(id)
        {
            BookId = bookId;
            ReviewerId = reviewerId;
            Rating = rating;
            Text = text;
        }

        protected Review() : base() { }
    }
}
