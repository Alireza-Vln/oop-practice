


public abstract class Guitar
{
    private int _count;
    private double _price;

    public Guitar(string brand, double price, string model, int count)
    {
        Brand = brand;
        Price = price;
        Model = model;
        Count = count;

    }
    public GuitarStyle Type { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Do not enter a number below zero");
            }
            else
                _price = value;
        }
    }

    public int Count
    {
        get { return _count; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Do not enter a number below zero");
            }
            else
                _count = value;
        }
    }
}
public class ClassicGuitar : Guitar
    {
        public ClassicGuitar(string brand, double price, string model, int count)
            : base(brand, price, model, count)
        {
        }

    }
    public class AcousticGuitar : Guitar
    {
        public AcousticGuitar(string brand, double price, string model, int count)
            : base(brand, price, model, count)
        {

        }

    }
    public class ElectricGuitar : Guitar
    {
        public ElectricGuitar(string brand, double price, string model, int count)
            : base(brand, price, model, count)
        {


        }

    }
    public class BassGuitar : Guitar
    {
        public BassGuitar(string brand, double price, string model, int count)
            : base(brand, price, model, count)
        {


        }

    }