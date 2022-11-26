// See https://aka.ms/new-console-template for more information
using Restaurant_system;

Console.WriteLine("-- Restaurant System --");

UserInterface userInterface = new UserInterface();
userInterface.Menu();
Console.WriteLine("Your Choise");
Console.ReadLine();
