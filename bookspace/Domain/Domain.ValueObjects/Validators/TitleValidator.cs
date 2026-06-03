using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Exceptions;

namespace Bookspace.Domain.ValueObjects.Validators
{
    public class TitleValidator : IValidator<string>
    {
        public void Validate(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new InvalidTitleException(title, "Book title cannot be empty.");
        }
    }
}