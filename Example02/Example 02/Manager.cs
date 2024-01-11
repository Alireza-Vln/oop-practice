public class Manager : Employee
{
    public Manager(int id, int salary, string department) : base(id, salary)
    {
        Department = department;
    }
    public override void PrintDetails(int id, int salary)
    {

        Console.WriteLine($"ID={id}---Salary={salary}---department={Department}");

    }

    public string Department { get; set; }
}
