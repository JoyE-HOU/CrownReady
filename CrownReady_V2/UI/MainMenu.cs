using DL;
namespace UI;
public class MainMenu{
    private IBL _bl;
    public MainMenu(IBL bl)
    {
        _bl = bl;
    }
    public void Start(){

        bool exit = false;
        Console.WriteLine("Welcome to CrownReady!");

        while(!exit)
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Manage Storefront");
            Console.WriteLine("[X] Exit");

            string? input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    Console.WriteLine("testing");
                    new StorefrontMenu(new CRBL(new FileRepo())).Start();
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