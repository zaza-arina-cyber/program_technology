using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Exceptions;

namespace Bookspace.Domain.ValueObjects.Validators
{
    public class AuthorValidator : IValidator<string>
    {
        public void Validate(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
                throw new InvalidAuthorException(author, "Book author cannot be empty.");
        }
    }
}