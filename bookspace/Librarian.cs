using Domain.bookspace.ValueObjects;

namespace Domain.Entities
{
    public class Librarian
    {
        public Guid Id { get; set; }
        public Username Username { get; set; }

        // Конструктор
        public Librarian(Guid id, Username username)
        {
            Id = id;
            Username = username;
        }
    }
}