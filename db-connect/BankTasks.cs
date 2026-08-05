using DbConnect.Data;
using DbConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DbConnect;

public static class BankTasks
{
    public static void RunBankTasks(AppDbContext db)
    {
        // Ensure customer table exists in learning_db
        db.Database.ExecuteSqlRaw(@"
            CREATE TABLE IF NOT EXISTS customer (
                account_no INT PRIMARY KEY,
                name VARCHAR(255) NOT NULL,
                address VARCHAR(255) NOT NULL,
                balance DECIMAL(65,30) NOT NULL
            );
        ");

        string[] addresses = { "Ktm", "Ltp", "Bkt" };
        var random = new Random();

        var sampleCustomers = new List<Customer>
        {
            new Customer { AccountNo = 100, Name = "Arun",  Address = addresses[random.Next(addresses.Length)], Balance = 75000 },
            new Customer { AccountNo = 101, Name = "Ram",   Address = addresses[random.Next(addresses.Length)], Balance = 60000 },
            new Customer { AccountNo = 102, Name = "Syam",  Address = addresses[random.Next(addresses.Length)], Balance = 45000 },
            new Customer { AccountNo = 103, Name = "Hari",  Address = addresses[random.Next(addresses.Length)], Balance = 85000 },
            new Customer { AccountNo = 104, Name = "Rita",  Address = addresses[random.Next(addresses.Length)], Balance = 65000 }
        };

        if (!db.Customers.Any())
        {
            db.Customers.AddRange(sampleCustomers);
            db.SaveChanges();
            Console.WriteLine("\n5 customer records inserted into 'learning_db' database successfully.");
        }

        var highBalanceCustomers = db.Customers
            .Where(c => c.Balance > 50000)
            .ToList();

        if (highBalanceCustomers.Any())
        {
            foreach (var c in highBalanceCustomers)
            {
                Console.WriteLine($"Account No: {c.AccountNo,-5} | Name: {c.Name,-10} | Address: {c.Address,-5} | Balance: {c.Balance,10:C}");
            }
        }
        else
        {
            Console.WriteLine("No customer records found with balance > 50000.");
        }
    }
}
