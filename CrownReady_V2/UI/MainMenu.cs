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
            Console.WriteLine("[1] Manage Storefront");
            Console.WriteLine("[X] Exit");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("testing");
                    new StorefrontMenu().Start();
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