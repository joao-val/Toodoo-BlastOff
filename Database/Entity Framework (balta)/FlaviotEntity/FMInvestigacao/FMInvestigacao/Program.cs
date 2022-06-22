// See https://aka.ms/new-console-template for more information
using FMInvestigacao.Data;
using FMInvestigacao.Model;

Console.WriteLine("Hello, World!");

using var context = new DataContext();

var vilao = new Vilao{
    Nome = "Thanos",
    NumCrime = 23
};

context.Viloes?.Add(vilao);

var crime = new Crime{
    Nome = "Equilibrio",
    Duracao = 3,
    Data = System.DateTime.Now,
    Local = "Terra",
    Vilao = vilao
};

context.Crimes?.Add(crime);
context.SaveChanges();
