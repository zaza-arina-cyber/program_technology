using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Validators;

namespace Bookspace.Domain.ValueObjects
{
    public class ReviewText : ValueObject<string>
    {
        public ReviewText(string value)
            : base(new ReviewTextValidator(), value) { }
    }
}