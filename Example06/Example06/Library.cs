interface IManage
{

    public void AddBook(Book Book);
    public void RemoveBook(string Bookname);
    public void ShowBook();
}
public class Library : IManage
{
    private List<Book> booklist;

    public Library()
    {
        booklist = new List<Book>();
    }


    public void AddBook(Book book)
    {
        if (book is Book B)
        {
            booklist.Add(B);
        }
        else
        {
            Console.WriteLine("Erorr");
        }

    }

    public void RemoveBook(string Bookname)
    {
        var book = booklist.Find(_ => _.Name == Bookname);

        if (book != null)
        {
            booklist.Remove(book);
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
    public void ShowBook()
    {
        foreach (var book in booklist)
        {

            Console.WriteLine($"name:{book.Name}----Count{book.Count}");
        }

    }

}
