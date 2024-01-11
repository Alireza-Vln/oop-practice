
public abstract class FastFood
{

    public FastFood(string name,int price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public int Price { get; set; }
}
public class Pitzza : FastFood
{
    public Pitzza(string name,int price):base(name,price)
    {
  
    }
  
}
public class Berger : FastFood
{
    public Berger(string name, int price) : base(name, price)
    {
     
    }
  
}

