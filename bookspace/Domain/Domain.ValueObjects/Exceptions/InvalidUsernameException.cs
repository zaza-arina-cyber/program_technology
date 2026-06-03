namespace Bookspace.Domain.ValueObjects.Exceptions
{
    public class InvalidUsernameException(string username, string message)
        : ArgumentException($"Invalid username '{username}': {message}")
    {
        public string Username => username;
    }
}