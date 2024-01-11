
string firstName = GetString("Enter FirstName");
string  lastName = GetString("Enter LastName ");
Person person = new Person(firstName, lastName);

Person.GetFullName(person);

static string GetString(string message)
{
    Console.WriteLine(message);
    string get = Console.ReadLine()!;
    return get;
}
