using DbConnect.Data;
using DbConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DbConnect;

public static class EmployeeTasks
{
    public static void RunEmployeeTasks(AppDbContext db)
    {
        // 1. Ensure the 'Address' column exists in the MySQL database table
        var hasAddressColumn = db.Database.SqlQueryRaw<int>(
            "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Employees' AND COLUMN_NAME = 'Address'"
        ).AsEnumerable().FirstOrDefault() > 0;

        if (!hasAddressColumn)
        {
            db.Database.ExecuteSqlRaw("ALTER TABLE Employees ADD COLUMN Address VARCHAR(255) NOT NULL DEFAULT '';");
        }

        string[] addresses = { "Ktm", "Ltp", "Bkt" };
        var random = new Random();

        // 2. Seed initial employees if table is empty
        if (!db.Employees.Any())
        {
            var initialEmployees = new List<Employee>
            {
                new Employee { Name = "Arun",  Salary = 75000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Ram",   Salary = 60000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Shyam", Salary = 45000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Hari",  Salary = 85000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Rita",  Salary = 65000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Sita",  Salary = 52000, Address = addresses[random.Next(addresses.Length)] },
                new Employee { Name = "Gita",  Salary = 40000, Address = addresses[random.Next(addresses.Length)] }
            };

            db.Employees.AddRange(initialEmployees);
            db.SaveChanges();
        }
        else
        {
            // Update existing records that have empty addresses with random values
            var unassigned = db.Employees.Where(e => string.IsNullOrEmpty(e.Address)).ToList();
            if (unassigned.Any())
            {
                foreach (var emp in unassigned)
                {
                    emp.Address = addresses[random.Next(addresses.Length)];
                }
                db.SaveChanges();
            }
        }

        var filteredEmployees = db.Employees
            .Where(e => e.Salary > 50000 && e.Address == "Ktm")
            .ToList();

        if (filteredEmployees.Any())
        {
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"ID: {emp.Id,-4} | Name: {emp.Name,-10} | Salary: {emp.Salary,10:C} | Address: {emp.Address}");
            }
        }
        else
        {
            Console.WriteLine("No employees found matching criteria (Salary > 50000 and Address = 'Ktm').");
        }

        // var allEmployees = db.Employees.ToList();
        // Console.WriteLine("\nAll Employee Records");
        // foreach (var emp in allEmployees)
        // {
        //     Console.WriteLine($"ID: {emp.Id,-4} | Name: {emp.Name,-10} | Salary: {emp.Salary,10:C} | Address: {emp.Address}");
        // }
    }
}
