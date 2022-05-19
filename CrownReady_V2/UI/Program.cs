// To create a new C# app, run: dotnet new console -n "UI"
// To add references, run: dotnet add reference ../Models/   

// using DL;
// using Models;

using UI;

// MainMenu menu = new MainMenu(new CRBL(new FileRepo()));
// // The below code is the breakdown of the line of code above.
// // IRepo repo = new FileRepo();
// // CRBL bl = new CRBL(repo);
// // MainMenu menu = new MainMenu(bl);

// menu.Start();

MenuFactory.GetMenu("main").Start();