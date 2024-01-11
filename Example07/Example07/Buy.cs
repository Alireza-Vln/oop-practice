public interface IBuy
 {
   
    public void ReduceTheNumber(string brand,string model);
   
}

public class Buyguitar : IBuy
{

    public void ReduceTheNumber(string barnd,string model)
    {
        var guitar=Shop.GetGuitarList().Find(_=>_.Brand==barnd && _.Model==model);
        if (guitar == null)
        {
            throw new Exception("not available");
        }
        if (guitar.Count == 0)
        {
            throw new Exception("not available");
        }
        guitar.Count--;
        
    }

}
public class Manage
{


    public Manage(double price)
    {
          Price = price;
      
    }

    public double Price { get; set; }
    public double Total { get; set; }
    public void Addprice(double price)
    {

       
            Total+= price;

    }
    
}
