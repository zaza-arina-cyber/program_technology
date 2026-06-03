using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Exceptions;

namespace Bookspace.Domain.ValueObjects.Validators
{
    public class ReviewTextValidator : IValidator<string>
    {
        public void Validate(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new InvalidReviewTextException(text, "Review text cannot be empty.");
        }
    }
}