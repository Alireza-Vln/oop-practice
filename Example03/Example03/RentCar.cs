

public abstract class RentCar
{
    protected RentCar(string name)
    {
        Name = name;
    
    }

    public string Name { get; set; }
    public int RentPrice { get; private set; }

    public int ProductionYear { get; private set; }
    public virtual void SetProductionYear(int productionYear)
    {
        if (productionYear < 1990 || productionYear > 2023)
        {
            throw new Exception();
        }
        ProductionYear = productionYear;
    }
    public virtual void SetRentPrice(int rentprice)
    {

        if (rentprice < 0)
        {
            throw new Exception();
        }
        RentPrice =rentprice;

    }
   
}


public class Foreign : RentCar
{
    public Foreign(string name):base(name)
    {
            
    }


    public override void SetProductionYear(int productionYear)
    {

        if (productionYear < 1990)
        {


            throw new Exception();
        }

        base.SetProductionYear(productionYear);
    }
    public override void SetRentPrice(int rentpirce)
    {

        if(rentpirce < 1000)
        {
            throw new Exception();
        }
        base.SetRentPrice(rentpirce);
    }
    
}
public class Iranian : RentCar
{
  
    public Iranian(string name) : base(name)
    {

    }

   
    public override void SetProductionYear(int productionYear)
    {
        
        if (productionYear >2020)
        {
throw new Exception();
        }

        base.SetProductionYear(productionYear);
    }

    public override void SetRentPrice(int rentpirce)
    {

        if (rentpirce < 500)
        {
            throw new Exception();
        }
        base.SetRentPrice(rentpirce);
    }


}

