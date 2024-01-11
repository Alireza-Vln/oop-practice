



string name = GetString("enter name");
int unit = GetInt("enter unit");
int score = GetInt("enter score");

int choose = GetInt("1)AssociateDegree----2)Masters");

if (choose == 1)
{
    var associateDegree = new AssociateDegree();
    associateDegree.GetStudent(name, unit, score);
    Console.WriteLine($"Name={associateDegree.Name}---Unit={associateDegree.Unit}---Score={associateDegree.Score}");


}
if (choose == 2)
{
    var masters = new Masters();
    masters.GetStudent(name, unit, score);
    Console.WriteLine($"Name={masters.Name}---Unit={masters.Unit}---Score={masters.Score}");

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