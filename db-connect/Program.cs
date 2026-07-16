using DbConnect.Models;
using DbConnect.Data;

using var db = new AppDbContext();

db.Database.EnsureCreated();

//
// CREATE
//
var user = new User
{
    Name = "Alice",
    Age = 20
};

db.Users.Add(user);
db.SaveChanges();

Console.WriteLine("User inserted.");

//
// READ (all users)
//
Console.WriteLine("\nUsers:");

foreach (var u in db.Users)
{
    Console.WriteLine($"{u.Id} {u.Name} ({u.Age})");
}

//
// READ (by primary key)
//
var existingUser = db.Users.Find(user.Id);

if (existingUser != null)
{
    Console.WriteLine($"\nFound: {existingUser.Name}");
}

//
// UPDATE
//
if (existingUser != null)
{
    existingUser.Name = "Bob";
    existingUser.Age = 25;

    db.SaveChanges();

    Console.WriteLine("\nUser updated.");
}

//
// READ again
//
Console.WriteLine("\nAfter update:");

foreach (var u in db.Users)
{
    Console.WriteLine($"{u.Id} {u.Name} ({u.Age})");
}

//
// DELETE
//
if (existingUser != null)
{
    db.Users.Remove(existingUser);
    db.SaveChanges();

    Console.WriteLine("\nUser deleted.");
}

//
// READ again
//
Console.WriteLine("\nAfter delete:");

foreach (var u in db.Users)
{
    Console.WriteLine($"{u.Id} {u.Name} ({u.Age})");
}
