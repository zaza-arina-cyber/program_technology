using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Validators;

namespace Bookspace.Domain.ValueObjects
{
    public class Rating : ValueObject<int>
    {
        public Rating(int value)
            : base(new RatingValidator(), value) { }
    }
}