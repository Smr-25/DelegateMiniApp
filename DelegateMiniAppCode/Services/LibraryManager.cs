using Utils.Exceptions;
using DelegateMiniAppCode.Models;


namespace DelegateMiniAppCode;

public class LibraryManager
{
    public int Limit { get; set; } = 2;

    private List<Book> Books { get; set; }

    public LibraryManager()
    {
        Books = new();
    }
    public void AddBook(Book book)
    {
       
        if (Books.Count == Limit)
            throw new CapacityLimitException("Capacity is full");
       
        if (Books.Any(b => b.Name.ToLower() == book.Name.ToLower() && !b.isDeleted))
            throw new AlreadyExistsException($"{book.Name} is already exist");
        Books.Add(book);
        Console.WriteLine($"{book.Id} Book is added");
    }

    public Book GetById(int? id)
    {
        if (id is null)
            throw new NullReferenceException($"{id} cannot be null");
        
        var exitsBook = Books.FirstOrDefault(b => b.Id == id  && !b.isDeleted);
        if (exitsBook is null)
            throw new NotFoundException($"{id} book notfound");
        return exitsBook;
    }
}
