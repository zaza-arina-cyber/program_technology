using Bookspace.Domain.Base;
using Bookspace.Domain.ValueObjects;

namespace Bookspace.Domain
{
    public class Librarian : Entity<Guid>
    {
        public Username Username { get; set; }

        public Librarian(Guid id, Username username) : base(id)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        protected Librarian() : base() => Username = null!;
    }
}