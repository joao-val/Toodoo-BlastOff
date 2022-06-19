// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

var user = new User
{
    Bio = "a",
    Email = "a@a.com",
    GitHub = "andrebaltieri",
    Image = "https://",
    Name = "André Baltieri",
    PasswordHash = "123",
    Slug = "andre-baltieri"
};

using var context = new BlogDataContext();
context.Users.Add(user);
context.SaveChanges();