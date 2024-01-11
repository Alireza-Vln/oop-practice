
public class Person
{

    public Person(string name, string family)
    {
        FirstName = name;
        LastName = family;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public static void GetFullName(Person person)
    {
        var fullName = person.FirstName + " " + person.LastName;
        Console.WriteLine(fullName);
    }
}