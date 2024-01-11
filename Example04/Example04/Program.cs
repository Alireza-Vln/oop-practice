 


int choose = GetInt("1)Enemy---2)Hero---3)Normal");



switch (choose)
{
    case 1:
        {
            string name=GetString("Name");
            var enemy = new Enemy(name);
            enemy.Name = name;
              Console.WriteLine($"name={enemy.Name}\npower={enemy.Power}\nspeed={enemy.Speed}\nhealth={enemy.Health}");
            break;
        }


    case 2:
        {
            string name = GetString("Name");
            var hero = new Hero(name);
            hero.Name = name;
            Console.WriteLine($"name={hero.Name}\npower={hero.Power}\nspeed={hero.Speed}\nhealth={hero.Health}");
            break;
        }


    case 3:
        {
            string name = GetString("Name");
            var normal = new Normal(name);
            normal.Name = name;
            Console.WriteLine($"name={normal.Name}\npower={normal.Power}\nspeed={normal.Speed}\nhealth={normal.Health}");
            break;
        }


    default:
        break;
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