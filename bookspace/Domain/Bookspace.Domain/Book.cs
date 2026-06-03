using Bookspace.Domain.Base;
using Bookspace.Domain.ValueObjects;

namespace Bookspace.Domain
{
    public enum BookStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Book : Entity<Guid>
    {
        public BookTitle Title { get; set; }
        public BookAuthor Author { get; set; }
        public BookStatus Status { get; set; }
        public Guid? RequestedBy { get; set; }
        public Guid? ProcessedBy { get; set; }

        public Book(Guid id, BookTitle title, BookAuthor author, BookStatus status,
                    Guid? requestedBy = null, Guid? processedBy = null) : base(id)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            Status = status;
            RequestedBy = requestedBy;
            ProcessedBy = processedBy;
        }

        protected Book() : base()
        {
            Title = null!;
            Author = null!;
        }
    }
}