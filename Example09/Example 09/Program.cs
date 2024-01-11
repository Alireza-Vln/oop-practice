  List<FastFood> listFood = new();
var manage = new ManageeOrders(0);

while (true)
{
    int menu = GetInt("1)add food\n2)order\n3)total");
    switch (menu)
    {

        case 1:
            {
                int Selection = GetInt("1)pitzza--2)berger");
                if (Selection == 1)
                {
                    string pitzzaName = GetString("enter pitzza name");
                    int pitzzaPrice = GetInt("enter pitzaa Price");
                    
                    var pitzza=new Pitzza(pitzzaName, pitzzaPrice);
                    listFood.Add(pitzza);
                }
                if (Selection == 2)
                {
                    string bergerName = GetString("enter berger name");
                    int bergerPrice = GetInt("enter berger Price");
                    var berger=new Berger(bergerName, bergerPrice);
                    listFood.Add(berger);
                }
                break;
            }
            case 2:
            {
               
                string order = GetString("what do you want?");
                var food = listFood.Find(_ => _.Name == order);
                manage.chest(food.Price);
                
              
                break;
            }
        case 3:
            {
                manage.show();

                break;
            }

        default:
            break;
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