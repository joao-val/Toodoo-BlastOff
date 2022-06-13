// See https://aka.ms/new-console-template for more information

using Dapper;
using Dapper.Models;
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
        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
        foreach(var category in categories)
        {
            Console.WriteLine($"{category.Id} - {category.Title}");
        }
    }
}

Console.WriteLine("Hello, World!");
