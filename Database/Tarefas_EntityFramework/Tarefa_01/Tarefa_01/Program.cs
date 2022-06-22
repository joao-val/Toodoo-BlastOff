// See https://aka.ms/new-console-template for more information
using Tarefa_01.Data;
using Tarefa_01.SpaceX;

using var context = new DataContext();

var task = new Tasks();

//task.Insert(context);
task.DeletePlanet(context);