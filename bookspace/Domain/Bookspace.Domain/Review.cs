using Bookspace.Domain.Base;
using Bookspace.Domain.ValueObjects;

namespace Bookspace.Domain
{
    public class Review : Entity<Guid>
    {
        public Guid BookId { get; set; }
        public Guid ReviewerId { get; set; }
        public Rating Rating { get; set; }
        public ReviewText Text { get; set; }

        public Review(Guid id, Guid bookId, Guid reviewerId, Rating rating, ReviewText text) : base(id)
        {
            BookId = bookId;
            ReviewerId = reviewerId;
            Rating = rating ?? throw new ArgumentNullException(nameof(rating));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        protected Review() : base()
        {
            Rating = null!;
            Text = null!;
        }
    }
}