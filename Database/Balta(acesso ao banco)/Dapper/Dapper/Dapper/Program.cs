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
    }
}

Console.WriteLine("Hello, World!");
