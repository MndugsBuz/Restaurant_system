// See https://aka.ms/new-console-template for more information
using Restaurant_system;
using Restaurant_system.Entities;

Console.WriteLine("-- Restaurant System --");

UserInterface userInterface = new UserInterface();
userInterface.Menu();
Console.WriteLine("Your Choise");
Console.ReadLine();
userInterface.MenuOption();
