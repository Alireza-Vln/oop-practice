List<ToDoList> myList = new();

while (true)
{
    string doit = GetString("What do you have in your schedule?");
    int day = GetInt("What day?");
    int month = GetInt("what month");
    int year = GetInt("what Year");
    if (day > 31 || month > 12)
    {
        Console.WriteLine("Error");
    }
    else
    {
        var time = new DateTime(year, month, day);
        var date = time.ToString("dd:MM:yyyy");
        var todolist = new ToDoList(doit, time,date);
        myList.Add(todolist);
        todolist.OrderingList(myList);
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