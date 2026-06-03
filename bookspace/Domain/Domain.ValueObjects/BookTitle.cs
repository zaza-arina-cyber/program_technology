using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Validators;

namespace Bookspace.Domain.ValueObjects
{
    public class BookTitle : ValueObject<string>
    {
        public BookTitle(string value)
            : base(new TitleValidator(), value) { }
    }
}
