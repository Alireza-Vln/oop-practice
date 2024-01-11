public interface Ordering
{
    public void OrderingList(List<ToDoList> order);

}



public class ToDoList : Ordering
{
    private DateTime _time;
    public void OrderingList(List<ToDoList> mylist)
    {
        var order = mylist.OrderBy(_ => _.Time);
        foreach (var item in order)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{item.DoIt}\n{item.Date}");
            Console.WriteLine("-------------------------");
        }

    }

    public ToDoList(string doit, DateTime time,string date)
    {
        DoIt = doit;
        Time = time;
        Date = date;
    }

    public DateTime Time
    {
        get
        {
            return _time;
        }


        set
        {
            if (value < DateTime.Now )
            {
                throw new Exception();
            }
            else
            {
                _time = value;
            }
        }


    }
    public string DoIt { get; set; }
    public string Date { get; set; }
}
