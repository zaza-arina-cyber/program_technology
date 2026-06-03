using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Validators;

namespace Bookspace.Domain.ValueObjects
{
    public class Username : ValueObject<string>
    {
        public Username(string value)
            : base(new UsernameValidator(), value) { }
    }
}
