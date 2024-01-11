
var library = new Library();

while (true)
{
    
    int choose = GetInt("1)add book--2)remove book--3)show books");
    switch (choose)
    { 

        case 1:
            {
               
                string bookname = GetString("enter book name");
                int bookcount = GetInt("enter count");
                var book = new Book(bookname,bookcount);
               library.AddBook(book);
                break;

            }
        case 2:
            {

                string bookname = GetString("enter book name");
               
                library.RemoveBook(bookname);


                break;
            }
        case 3:
            {

                library.ShowBook();
                break;
            }
    }

}
    static int GetInt(string message)
    {
        Console.WriteLine(message);
        int get = int.Parse(Console.ReadLine()!);
        return get;
    }


    static string GetString(string message)
    {
        Console.WriteLine(message);
        string get = Console.ReadLine()!;
        return get;
    }