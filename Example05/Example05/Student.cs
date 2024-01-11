


interface IStudents
{

    public void GetStudent(string name, int unit, int score);
}

public class AssociateDegree : IStudents
{
    private int _score;
    public void GetStudent(string name, int unit, int score)
    {
        Name = name;
        Unit = unit;
        Score = score;

    }

    
    public string Name { get; set; }

    public int Unit { get; set; }
    public int Score
    {
        get { return _score; }
        set
        {
            if (value > 20 || value < 0)
            {
                throw new Exception();
            }
            else { _score = value; }
        }
    }
}
public class Masters : IStudents
{
    private int _score;
    public void GetStudent(string name, int unit, int score)
    {
        Name = name;
        Unit = unit;
        Score = score;

    }



    public string Name { get; set; }

    public int Unit { get; set; }
    public int Score
    {
        get { return _score; }
        set
        {
            if (value > 20 || value < 0)
            {
                throw new Exception();
            }
            else { _score = value; }
        }
    }
}






