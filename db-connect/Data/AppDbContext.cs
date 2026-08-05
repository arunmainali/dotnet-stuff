using DbConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DbConnect.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Customer> Customers => Set<Customer>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString =
            "Server=localhost;" +
            "Database=learning_db;" +
            "User=root;" +
            "Password=1234;";

        options.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString));
    }
}
