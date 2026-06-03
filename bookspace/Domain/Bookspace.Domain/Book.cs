using BookService.Domain.Base;

namespace BookService.Domain
{
    public enum BookStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Book : Entity<Guid>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public Guid? RequestedBy { get; set; }
        public Guid? ProcessedBy { get; set; }

        public Book(Guid id, string title, string author, BookStatus status,
                    Guid? requestedBy = null, Guid? processedBy = null) : base(id)
        {
            Title = title;
            Author = author;
            Status = status;
            RequestedBy = requestedBy;
            ProcessedBy = processedBy;
        }

        protected Book() : base() { }
    }
}