// using DL;
using BL;
using Models;

namespace UI;

public class MainMenu{
    private CRBL _bl;
    public MainMenu()
    {
        _bl = new CRBL();
    }
    public void Start(){

        bool exit = false;
        Console.WriteLine("Welcome to CrownReady!");

        while(!exit)
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Create a new storefront");
            Console.WriteLine("2. View All Locations");
            Console.WriteLine("X. Exit");
            string? response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Console.WriteLine("Name: ");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Address: ");
                    string? address = Console.ReadLine();
                    Console.WriteLine("City: ");
                    string? city = Console.ReadLine();
                    Console.WriteLine("State: ");
                    string? state = Console.ReadLine();
            
                    // initialized a class using object initializer instead of an empty constructor
                    Storefront newStorefront = new Storefront{
                        Name = name,
                        Address = address,
                        City = city,
                        State = state
                    };

                    _bl.AddStorefront(newStorefront);


                    Console.WriteLine("Would you like to add another one? [y/n]");
                    string? input = Console.ReadLine();
                        if(input == "n")
                        {
                            exit = true;
                        }
                    break;

                    case "2":
                    Console.WriteLine("Here are all your storefronts:");
                    List<Storefront> allStorefronts = _bl.GetAllStorefronts();
                    foreach(Storefront store in allStorefronts)
                    {
                    Console.WriteLine($"Store: {store.Name} \nAddress: {store.Address} \nCity: {store.City} \nState: {store.State}");
                    }
                    break;

                    default:
                        Console.WriteLine("Try again please.");
                        break;
            }

        }

    }

}