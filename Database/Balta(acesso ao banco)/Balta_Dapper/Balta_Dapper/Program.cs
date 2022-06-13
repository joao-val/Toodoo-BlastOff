// See https://aka.ms/new-console-template for more information

using Dapper;
using Dapper.Models;
using Microsoft.Data.SqlClient;

var connectionString = new SqlConnection(@"Server= localhost,1433; Database=balta;User Id=sa;Password=Algar123; TrustServerCertificate = True;");

var category = new Category();
category.Id = Guid.NewGuid();
category.Title = "Amazon AWS";
category.Url = "amazon";
category.Description = "Categoria destinada a serviços do AWS";
category.Order = 8;
category.Summary = "AWS Cloud";
category.Featured = false;

// SQL injection 'INSERT INTO Users VALUES()'

var insertSql = $@"INSERT INTO 
        [Category] 
    VALUES(
        @Id, 
        @Title, 
        @Url, 
        @Summary, 
        @Order, 
        @Description, 
        @Featured)";


using (var connection = connectionString)
{
    var rows = connection.Execute(insertSql, new
    {
        category.Id,
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
    });
    Console.WriteLine($"{rows} linhas inseridas");

    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach(var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
    
}

Console.WriteLine("Hello, World!");
