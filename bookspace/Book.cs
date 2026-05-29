using Domain.Enums; 

namespace Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatusEnum Status { get; set; }  
        public Guid? RequestedBy { get; set; }   // ID читателя, если книгу запросили
        public Guid? ProcessedBy { get; set; }   // ID библиотекаря, который обработал

        // Конструктор
        public Book(Guid id, string title, string author, BookStatusEnum status,  
                    Guid? requestedBy = null, Guid? processedBy = null)
        {
            Id = id;
            Title = title;
            Author = author;
            Status = status;
            RequestedBy = requestedBy;
            ProcessedBy = processedBy;
        }

        // Одобрить книгу (библиотекарь)
        public void Approve(Guid librarianId)
        {
            Status = BookStatusEnum.Approved;  
            ProcessedBy = librarianId;
        }

        // Отклонить книгу (библиотекарь)
        public void Reject(Guid librarianId)
        {
            Status = BookStatusEnum.Rejected;  
            ProcessedBy = librarianId;
        }

        // Проверка, может ли читатель запросить эту книгу
        public bool CanBeRequestedByReader()
        {
            return Status == BookStatusEnum.Pending && RequestedBy == null; 
        }
    }
}