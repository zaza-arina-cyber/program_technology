using Bookspace.Domain.ValueObjects.Base;
using Bookspace.Domain.ValueObjects.Exceptions;

namespace Bookspace.Domain.ValueObjects.Validators
{
    public class UsernameValidator : IValidator<string>
    {
        public void Validate(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length <= 2)
                throw new InvalidUsernameException(username, "Username must be longer than 2 characters and not empty.");
        }
    }
}