// See https://aka.ms/new-console-template for more information

using Dapper;
using Dapper.Models;
using Microsoft.Data.SqlClient;
using System.Data;

const string connectionString = @"Server= localhost,1433; Database=balta;User Id=sa;Password=Algar123; TrustServerCertificate = True;";

using (var connection = new SqlConnection(connectionString))
{
    //CreateCategory(connection);
    //CreateManyCategory(connection);
    //UpdateCategory(connection);
    //DeleteCategory(connection);
    //ListCategories(connection);
    //ExecuteProcedure(connection);
    ExecuteReadProcedure(connection);

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

static void DeleteCategory(SqlConnection connection)
{
    var deleteQuery = "DELETE [Category] WHERE [Id] =@id ";
    var rows = connection.Execute(deleteQuery, new
    {
        id = "203fda4c-b4a1-4630-82d0-637bbc7ced2b"
    });
    Console.WriteLine($"{rows} registros deletados");
}

static void CreateManyCategory(SqlConnection connection)
{
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var category2 = new Category();
    category2.Id = Guid.NewGuid();
    category2.Title = "Categoria Nova";
    category2.Url = "categoria-nova";
    category2.Description = "Categoria nova";
    category2.Order = 9;
    category2.Summary = "Categoria";
    category2.Featured = true;

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

    var rows = connection.Execute(insertSql, new[]{
        new
        {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        },
        new
        {
            category2.Id,
            category2.Title,
            category2.Url,
            category2.Summary,
            category2.Order,
            category2.Description,
            category2.Featured
        }
    });
    Console.WriteLine($"{rows} linhas inseridas");
}

static void ExecuteProcedure(SqlConnection connection)
{
    var procedure = "[spDeleteStudent]";
    var pars = new { StudentId = "91bd1f80-25ed-4523-a425-2c2cd66f4bfd" };
    var affectedRows = connection.Execute(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    Console.WriteLine($"{affectedRows} alunos deletados");
}

static void ExecuteReadProcedure(SqlConnection connection)
{
    var procedure = "[spGetCoursesByCategory]";
    var pars = new { @CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
    var courses = connection.Query(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

    foreach(var item in courses)
    {
        Console.WriteLine($"{item.Title}");
    }
}