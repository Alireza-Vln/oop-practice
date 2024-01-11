public abstract class Character
{
    protected Character(string name)
    {
        Name = name;
    }
    public string Name { get; set; }


}
public class Enemy : Character
{
    private int _power;
    private int _speed;
    private int _health;
    public Enemy(string name) : base(name)
    {
        Power=_power;
        Speed=_speed;
        Health=_health;
    }
    public int Power
    {
        get { return _power; }
        set
        {
            value = 100;

            _power = value;

        }
    }
    public int Speed
    {
        get { return _speed; }
        set
        {
            value = 120;

            _speed = value;

        }
    }
    public int Health
    {
        get { return _health; }
        set
        {
            value = 220;

            _health = value;

        }
    }
}



public class Hero : Character
{
    private int _power;
    private int _speed;
    private int _health;
    public Hero(string name) : base(name)
    {
        Power = _power;
        Speed = _speed;
        Health = _health;
    }
    public int Power
    {
        get { return _power; }
        set
        {
            value = 150;

            _power = value;

        }
    }
    public int Speed
    {
        get { return _speed; }
        set
        {
            value = 110;

            _speed = value;

        }
    }
    public int Health
    {
        get { return _health; }
        set
        {
            value = 180;

            _health = value;

        }
    }
}
public class Normal : Character
{
    private int _power;
    private int _speed;
    private int _health;
    public Normal(string name) : base(name)
    {
        Power = _power;
        Speed = _speed;
        Health = _health;
    }
    public int Power
    {
        get { return _power; }
        set
        {
            value = 100;

            _power = value;

        }
    }
    public int Speed
    {
        get { return _speed; }
        set
        {
            value = 250;

            _speed = value;

        }
    }
    public int Health
    {
        get { return _health; }
        set
        {
            value = 150;

            _health = value;

        }
    }
}