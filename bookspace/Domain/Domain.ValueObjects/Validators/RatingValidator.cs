using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Exceptions;

namespace Bookspace.Domain.ValueObjects.Validators
{
    public class RatingValidator : IValidator<int>
    {
        public void Validate(int rating)
        {
            if (rating < 1 || rating > 5)
                throw new InvalidRatingException(rating, "Rating must be between 1 and 5.");
        }
    }
}