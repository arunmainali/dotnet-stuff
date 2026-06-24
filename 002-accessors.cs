using System;

class Employee {
    private string empName = "";

    public string Name {
        get { return empName; }
        set { empName = value; }
    }
}

class Program {
    static void Main() {
        Employee emp = new Employee();

        emp.Name = "Arun Mainali";
        Console.WriteLine(emp.Name);
    }
}
