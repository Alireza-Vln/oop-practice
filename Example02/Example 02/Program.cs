
int id = GetInt("enter Employee Id");
int salary = GetInt("enter Salary");
int getEmpoly = GetInt("1)employee__2)manager");

if (getEmpoly == 1)
{
    Employee empolyee = new Employee(id, salary);
    empolyee.PrintDetails(id, salary);

}
if (getEmpoly == 2)
{
    string department = GetString("enter department");
    Employee maneger = new Manager(id, salary, department);
    maneger.PrintDetails(id, salary);
}

static string GetString(string message)
{
    Console.WriteLine(message);
    string get = Console.ReadLine()!;
    return get;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    int get = int.Parse(Console.ReadLine());
        return get;
}
