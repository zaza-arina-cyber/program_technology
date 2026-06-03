using Bookspace.Domain.Base;
using Bookspace.Domain.ValueObjects;

namespace Bookspace.Domain
{
    public class Reader : Entity<Guid>
    {
        public Username Username { get; set; }

        public Reader(Guid id, Username username) : base(id)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        protected Reader() : base() => Username = null!;
    }
}