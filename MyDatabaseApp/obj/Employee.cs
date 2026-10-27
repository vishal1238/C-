using Microsoft.Data.Sqlite;

string connectionString = "Data Source=college.db";

// Connect to the database (creates the file if it doesn't exist)
using var connection = new SqliteConnection(connectionString);
connection.Open();

// Recreate the table to avoid stale schema from an earlier run
using (var resetCommand = new SqliteCommand("DROP TABLE IF EXISTS Students;", connection))
{
    resetCommand.ExecuteNonQuery();
}

// Create a table
string createTable = @"
CREATE TABLE IF NOT EXISTS Students (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Email TEXT NOT NULL,
    Age INTEGER NOT NULL,
    Course TEXT NOT NULL,
    City TEXT NOT NULL
);";

using var createCommand = new SqliteCommand(createTable, connection);
createCommand.ExecuteNonQuery();

Console.WriteLine("Database and table created successfully!");

// Insert a student
string insertQuery =
    "INSERT INTO Students (Name, Email, Age, Course, City) VALUES (@name, @email, @age, @course, @city);";

using var insertCommand = new SqliteCommand(insertQuery, connection);
insertCommand.Parameters.AddWithValue("@name", "Rahul");
insertCommand.Parameters.AddWithValue("@email", "rahul@example.com");
insertCommand.Parameters.AddWithValue("@age", 20);
insertCommand.Parameters.AddWithValue("@course", "Computer Science");
insertCommand.Parameters.AddWithValue("@city", "New York");
insertCommand.ExecuteNonQuery();

Console.WriteLine("Student inserted successfully!");

// Read students
string selectQuery = "SELECT Id, Name, Email, Age, Course, City FROM Students;";

using var selectCommand = new SqliteCommand(selectQuery, connection);
using var reader = selectCommand.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(
        $"{reader["Id"]}: {reader["Name"]} - {reader["Email"]} - {reader["Age"]} - {reader["Course"]} - {reader["City"]}"
    );
}
