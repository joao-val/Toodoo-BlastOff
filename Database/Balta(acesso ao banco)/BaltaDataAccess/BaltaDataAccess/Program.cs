// See https://aka.ms/new-console-template for more information

using Microsoft.Data.SqlClient;

var connectionString = new SqlConnection(@"Server= localhost,1433; Database=balta;User Id=sa;Password=Algar123; TrustServerCertificate = True;");
// Microsoft.Data.SqlClient

//var connection = new SqlConnection();
//connection.Open();
//connection.Close();
//connection.Dispose();

using (var connection = connectionString)
{
    Console.WriteLine("Connect");
    connection.Open();

    using (var command = new SqlCommand())
    {
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
        }
    }
}

Console.WriteLine("Hello, World!");
