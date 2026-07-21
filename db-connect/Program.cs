using DbConnect.Models;
using DbConnect.Data;

using var db = new AppDbContext();

while (true)
{
	Console.WriteLine("\n--- User Management ---");
	Console.WriteLine("1. Add User");
	Console.WriteLine("2. View All Users");
	Console.WriteLine("3. Update User");
	Console.WriteLine("4. Delete User");
	Console.WriteLine("5. Exit");
	Console.Write("Choose an option: ");

	var input = Console.ReadLine();

	switch (input)
	{
		case "1":
			Console.Write("Enter name: ");
			var name = Console.ReadLine() ?? "";
			Console.Write("Enter age: ");
			if (int.TryParse(Console.ReadLine(), out int age))
			{
				var newUser = new User { Name = name, Age = age };
				db.Users.Add(newUser);
				db.SaveChanges();
				Console.WriteLine("User added successfully.");
			}
			else
			{
				Console.WriteLine("Invalid age.");
			}
			break;

		case "2":
			var users = db.Users.ToList();
			if (users.Any())
			{
				Console.WriteLine("\nUsers:");
				foreach (var u in users)
				{
					Console.WriteLine($"ID: {u.Id}, Name: {u.Name}, Age: {u.Age}");
				}
			}
			else
			{
				Console.WriteLine("No users found.");
			}
			break;

		case "3":
			Console.Write("Enter User ID to update: ");
			if (int.TryParse(Console.ReadLine(), out int updateId))
			{
				var userToUpdate = db.Users.Find(updateId);
				if (userToUpdate != null)
				{
					Console.Write($"Enter new name (current: {userToUpdate.Name}): ");
					var newName = Console.ReadLine();
					if (!string.IsNullOrWhiteSpace(newName))
					{
						userToUpdate.Name = newName;
					}

					Console.Write($"Enter new age (current: {userToUpdate.Age}): ");
					var ageInput = Console.ReadLine();
					if (int.TryParse(ageInput, out int newAge))
					{
						userToUpdate.Age = newAge;
					}

					db.SaveChanges();
					Console.WriteLine("User updated successfully.");
				}
				else
				{
					Console.WriteLine("User not found.");
				}
			}
			else
			{
				Console.WriteLine("Invalid ID.");
			}
			break;

		case "4":
			Console.Write("Enter User ID to delete: ");
			if (int.TryParse(Console.ReadLine(), out int deleteId))
			{
				var userToDelete = db.Users.Find(deleteId);
				if (userToDelete != null)
				{
					db.Users.Remove(userToDelete);
					db.SaveChanges();
					Console.WriteLine("User deleted successfully.");
				}
				else
				{
					Console.WriteLine("User not found.");
				}
			}
			else
			{
				Console.WriteLine("Invalid ID.");
			}
			break;

		case "5":
			Console.Write("Enter name to search: ");
			var searchName = Console.ReadLine() ?? "";

			var matchingUsers = db.Users
				.Where(u => u.Name.Contains(searchName))
				.ToList();

			if (matchingUsers.Any())
			{
				foreach (var user in matchingUsers)
				{
					Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
				}
			}
			else
			{
				Console.WriteLine("No matching users found.");
			}

			break;

		case "6":
			return;
		default:
			Console.WriteLine("Invalid option. Please try again.");
			break;
	}
}
