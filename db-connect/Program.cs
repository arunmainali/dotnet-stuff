using MySqlConnector;

string connectionString =
    "Server=localhost;" +
    "Database=dotnetdb;" +
    "User ID=root;" +
    "Password=1234;";

using var connection = new MySqlConnection(connectionString);

connection.Open();

Console.WriteLine("Connected!");

using var command = new MySqlCommand(
    "SELECT id, name FROM users;",
    connection);

using var reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)}");
}
