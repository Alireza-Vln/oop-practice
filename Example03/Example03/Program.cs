
string carname = GetString("enter car name");
int productionYear = GetInt("enter ProductionYear ");
int rentprice = GetInt("enter rent price");
int res = GetInt("1)Irani-Foreign");
if (res == 1)
{
    var irani = new Iranian(carname);
    irani.SetProductionYear(productionYear);
    irani.SetRentPrice(rentprice);
    Console.WriteLine($"name={irani.Name}--productionYear={irani.ProductionYear}--rentPrice={irani.RentPrice}");
}
if (res == 2)
{
    var foreign = new Foreign(carname);
    foreign.SetProductionYear(productionYear);
    foreign.SetRentPrice(rentprice);
    Console.WriteLine($"name={foreign.Name}--productionYear={foreign.ProductionYear}--rentPrice={foreign.RentPrice}");
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