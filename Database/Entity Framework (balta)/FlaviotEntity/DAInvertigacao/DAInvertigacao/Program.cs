// See https://aka.ms/new-console-template for more information
using DAInvestigacao.Data;
using DAInvestigacao.Model;

Console.WriteLine("Hello, World!");

using var context = new DataContext();

var vilao = new Vilao{
    Nome = "Loki",
    NumCrime = 56
};

context.Viloes?.Add(vilao);

var crime = new Crime{
    Nome = "Invasão Alienígena",
    Duracao = 1,
    Data = System.DateTime.Now,
    Local = "Terra",
    Vilao = vilao
};

context.Crimes?.Add(crime);
context.SaveChanges();
