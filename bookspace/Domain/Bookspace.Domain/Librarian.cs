using BookService.Domain.Base;

namespace BookService.Domain
{
    public class Librarian : Entity<Guid>
    {
        public string Username { get; set; }

        public Librarian(Guid id, string username) : base(id)
        {
            Username = username;
        }

        protected Librarian() : base() { }
    }
}