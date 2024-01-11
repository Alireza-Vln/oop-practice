public interface Ichest
{
    public void chest(int Price);
}
public class ManageeOrders:Ichest
{
    public ManageeOrders(int price)
    {
       
        Price=price;
        
    }

    public int Price { get; set; }
    public int Total { get; set; } 
    public void chest(int Price)
    {
        
       Total += Price;
       
    }
   public void show()
    {
        Console.WriteLine($"Total={Total}");
    }
   
}

