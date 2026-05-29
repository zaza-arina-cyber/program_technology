using Domain.bookspace.ValueObjects;

namespace Domain.Entities
{
    public class Reader
    {
        public Guid Id { get; set; }
        public Username Username { get; set; }

        // Конструктор
        public Reader(Guid id, Username username)
        {
            Id = id;
            Username = username;
        }
    }
}