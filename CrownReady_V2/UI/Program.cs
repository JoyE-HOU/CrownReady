// To create a new C# app, run: dotnet new console -n "UI"
// To add references, run: dotnet add reference ../Models/   
using DL;
using Models;
using UI;

MainMenu menu = new MainMenu(new CRBL(new FileRepo()));
menu.Start();