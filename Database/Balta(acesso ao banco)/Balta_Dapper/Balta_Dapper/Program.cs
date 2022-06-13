// See https://aka.ms/new-console-template for more information

using Dapper;
using Dapper.Models;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server= localhost,1433; Database=balta;User Id=sa;Password=Algar123; TrustServerCertificate = True;";

using (var connection = new SqlConnection(connectionString))
{
    UpdateCategory(connection);
    ListCategories(connection);
    //CreateCategory(connection);
}


static void ListCategories(SqlConnection connection) 
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}

static void CreateCategory(SqlConnection connection)
{
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
}

static void UpdateCategory(SqlConnection connection)
{
    var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
    var rows = connection.Execute(updateQuery, new
    {
        id = new Guid("9f3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2022"
    });

    Console.WriteLine($"{rows} registros atualizadas");
}