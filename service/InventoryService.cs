public interface IInventoryService
{
    void AddBook(Book book);
    void SearchBookByTitle(string title);
    List<Book> GetAllBook();
}