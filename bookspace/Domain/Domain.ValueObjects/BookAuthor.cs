using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Validators;

namespace Bookspace.Domain.ValueObjects
{
    public class BookAuthor : ValueObject<string>
    {
        public BookAuthor(string value)
            : base(new AuthorValidator(), value) { }
    }
}
