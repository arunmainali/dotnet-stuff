public class Person
{
    protected string id = "1307";
    protected string name = "Arun Mainali";

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
    }
}
class Employee : Person
{
    public readonly string id = "ABCDEFG";
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Employee ID: {id}");
    }
}

class Program
{
    static void Main()
    {
        Employee E = new Employee();
        E.GetInfo();
        Console.WriteLine("This code is run by Arun Mainali");
    }
}
