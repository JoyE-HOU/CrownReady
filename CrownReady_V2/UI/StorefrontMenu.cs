using DL;
namespace UI;
public class StorefrontMenu
{
    private IBL _bl;

    public StorefrontMenu(IBL bl)
    {
        _bl = bl;
    }
    public void Start()
    {
        bool exit = false;

        while(!exit)
        {
        Console.WriteLine("Welcome to the Storefront Menu!");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("[1] Create a new storefront");
        Console.WriteLine("[2] View All Locations");
        Console.WriteLine("[X] Exit");

        string? input = Console.ReadLine();

        switch (input)
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
                    string? response = Console.ReadLine();
                        if(response == "n")
                        {
                            exit = true;
                        }
                    break;

                case "2":
                    Console.WriteLine("Here are all your storefronts:");
                    List<Storefront> allStorefronts = _bl.GetAllStorefronts();
                    if(allStorefronts.Count == 0)
                    {
                        Console.WriteLine("No storefronts found :/");
                    }
                    else
                    {
                    foreach(Storefront store in allStorefronts)
                    {
                    Console.WriteLine($"Store: {store.Name} \nAddress: {store.Address} \nCity: {store.City} \nState: {store.State}");
                    }
                    }
                    break;
                
                case "x":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Try again please.");
                    break;
            }
        }
    }
}