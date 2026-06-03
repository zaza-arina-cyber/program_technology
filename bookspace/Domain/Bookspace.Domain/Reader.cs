using BookService.Domain.Base;

namespace BookService.Domain
{
    public class Reader : Entity<Guid>
    {
        public string Username { get; set; }

        public Reader(Guid id, string username) : base(id)
        {
            Username = username;
        }

        protected Reader() : base() { }
    }
}