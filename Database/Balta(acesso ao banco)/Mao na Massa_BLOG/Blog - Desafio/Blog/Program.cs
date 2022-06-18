// See https://aka.ms/new-console-template for more information
using Blog;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string ConnectionString = @"Server= localhost,1433; Database=Blog;User Id=sa;Password=Algar123; TrustServerCertificate = True;";

Database.Connection = new SqlConnection(ConnectionString);
Database.Connection.Open();

static void Load()
{
    Console.Clear();
    Console.WriteLine("Meu Blog");
    Console.WriteLine("-----------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuário");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Vincular perfil/usuário");
    Console.WriteLine("6 - Vincular post/tag");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();
    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 4:
            MenuTagScreen.Load();
            break;
        default: Load(); break;
    }
}
    Database.Connection.Close();
Console.ReadKey();