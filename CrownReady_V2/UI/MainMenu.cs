using Models;

namespace UI;

public class MainMenu{

    public List<Storefront> allStorefronts = new List<Storefront>();
    public void Start(){


        bool exit = false;
        Console.WriteLine("Welcome to CrownReady!");

        while(!exit)
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Create a new storefront");
            Console.WriteLine("2. Exit");
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
                    break;
            
                    // initialized a class using object initializer instead of an empty constructor
                    Storefront newStorefront = new Storefront{
                        Name = name,
                        Address = address,
                        City = city,
                        State = state
                    };

                    this.allStorefronts.Add(newStorefront);

                    Console.WriteLine("Here are all your storefronts:");
                    foreach(Storefront store in this.allStorefronts)
                    {
                    Console.WriteLine($" Store: {store.Name} \nAddress: {store.Address} \nCity: {store.City} \nState: {store.State}");
                    }

                    Console.WriteLine("Would you like to add another one? [y/n]");
                    string? input = Console.ReadLine();
                        if(input == "n")
                        {
                            exit = true;
                        }
                    default:
                        Console.WriteLine("Try again please.");
                        break;
            }

        }

    }

}