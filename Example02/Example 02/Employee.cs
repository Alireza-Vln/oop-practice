public  class Employee
{
    public Employee(int id,int salary)
    {
        EmpolyeeId=id;
        Salary = salary;
    }

    public int EmpolyeeId { get; set; }
    public int Salary { get; set; }

    public virtual void PrintDetails(int id,int salary)
    {
        Console.WriteLine($"ID={id}---Salary={salary}");
    }
}
