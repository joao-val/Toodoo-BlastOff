// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


using var context = new BlogDataContext();

//var user = new User
//{
//    Name = "André Baltieri",
//    Slug = "andrebaltieri",
//    Email = "andre@balta.io",
//    Bio = "9x Microsoft MVP",
//    Image = "https://balta.io",
//    PasswordHash = "123098457"
//};

//var category = new Category
//{ 
//    Name = "Backend",
//    Slug = "backend"
//};

//// SCOPE_IDENTITY
//var post = new Post
//{
//    Author = user,
//    Category = category,
//    Body = "<p>Hello world</p>",
//    Slug = "comecando-com-ef-core",
//    Summary = "Neste artigo vamos aprender EF core",
//    Title = "Começando com EF core",
//    CreateDate = DateTime.Now,
//    LastUpdateDate = DateTime.Now,
//};

//context.Posts.Add(post);
//context.SaveChanges();

var posts = context
    .Posts
    .AsNoTracking()
    .Include(x => x.Author)
    .Include(x => x.Category)
    .OrderByDescending(x => x.LastUpdateDate)
    .ToList();

foreach (var post in posts)
{
    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
}

