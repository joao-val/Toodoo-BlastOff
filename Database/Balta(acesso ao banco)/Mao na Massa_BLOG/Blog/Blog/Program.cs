// See https://aka.ms/new-console-template for more information
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string ConnectionString = @"Server= localhost,1433; Database=Blog;User Id=sa;Password=Algar123; TrustServerCertificate = True;";

var connection = new SqlConnection(ConnectionString);
connection.Open();

ReadUsersWithRoles(connection);
//CreateUser(connection);
//ReadRoles(connection);
//ReadTags(connection);

//ReadUser();
//CreateUser();
//UpdateUser();
//DeleteUser();
connection.Close();

static void ReadUsersWithRoles(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var items = repository.GetWithRoles();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
        foreach (var role in item.Roles)
        {
            Console.WriteLine($"- {role.Name}");
        }
    }
}

static void CreateUser(SqlConnection connection)
{
    var user = new User()
    {
        Email = "email@balta.io",
        Bio = "bio",
        Image = "imagem",
        Name = "Name",
        PasswordHash = "hash",
        Slug = "slug"
    };

    var repository = new Repository<User>(connection);
    repository.Create(user);
    
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var items = repository.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
    }
}

static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var items = repository.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
    }
}

