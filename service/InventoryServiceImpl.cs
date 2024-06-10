public class InventoryServiceImpl : IInventoryService
{
    private List<Book> books;

    public InventoryServiceImpl()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void SearchBookByTitle(string title)
    {
        foreach (var book in books)
        {
            if (book.Title == title)
            {
                Console.WriteLine($"Title: {book.Title}, Code: {book.Code}, Publisher: {book.Publisher}, Publication Year: {book.PublicationYear}");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    public List<Book> GetAllBook()
    {
        return books;
    }

}