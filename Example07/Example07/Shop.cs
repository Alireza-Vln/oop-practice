
public static class Shop
{
    private static List<Guitar> guitarList = new();
    private static List<string> guitarSold=new();
    private static Manage manage=new Manage(0);

    public static int GetInt(string message)
    {
        Console.WriteLine(message);
        int get = int.Parse(Console.ReadLine()!);
        return get;
    }


    public static string GetString(string message)
    {
        Console.WriteLine(message);
        string get = Console.ReadLine()!;
        return get;
    }



    public static double GetDouble(string message)
    {
        Console.WriteLine(message);
        double get = double.Parse(Console.ReadLine());
        return get;
    }

    public static void AddBass(string barnd, string model, double price, int count)
    {

        var bassguitar = new BassGuitar(barnd, price, model, count);
        bassguitar.Type = GuitarStyle.Bass;
        guitarList.Add(bassguitar);
    }
    public static void AddClassic(string barnd, string model, double price, int count)
    {
        var classicguitar = new ClassicGuitar(barnd, price, model, count);
        classicguitar.Type = GuitarStyle.Classic;
        guitarList.Add(classicguitar);
    }
    public static void AddAcoustic(string barnd, string model, double price, int count)
    {
        var acousticguitar = new AcousticGuitar(barnd, price, model, count);
        acousticguitar.Type= GuitarStyle.Acoustic;
        guitarList.Add(acousticguitar);
    }
    public static void AddElectric(string barnd, string model, double price, int count)
    {
        var electricguitar = new ElectricGuitar(barnd, price, model, count);
        electricguitar.Type=GuitarStyle.Electric;
        guitarList.Add(electricguitar);
    }
    public static void ShowGuitarList()
    {
        foreach (var guitar in guitarList)
        {

            Console.WriteLine($"{guitar.Type}::brand:{guitar.Brand}--model:{guitar.Model}--price:{guitar.Price}--count:{guitar.Count}");

        }
    }
   public static List<Guitar> GetGuitarList()
    {
        return guitarList;
    }
   
    public static void Buy(string brand,string model)
    {
        var buy = new Buyguitar();
        buy.ReduceTheNumber(brand, model);
        var add = guitarList.Find(_ => _.Brand == brand && _.Model == model);
        if (add == null)
        {
            throw new Exception("not available");
        }
        manage.Addprice(add.Price);
        guitarSold.Add(add.Brand);
    }
    public static void ShowTotal()
    {
        foreach(var sold in guitarSold)
        {
            Console.WriteLine($"Brand:{sold}");
        }
        Console.WriteLine("----------------------");
        Console.WriteLine($"Total=={manage.Total}");

    }
    public static void RemoveGuitar(string model)
    {
        var remove=guitarList.Find(_ => _.Model == model);
        guitarList.Remove(remove);
    }
}

public enum GuitarStyle
{
    Bass,
    Electric,
    Classic,
    Acoustic,

}