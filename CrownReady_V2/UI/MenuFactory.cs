using DL;
namespace UI;

public static class MenuFactory
{
    public static IMenu GetMenu(string menuString)
    {
        menuString = menuString.ToLower();
        IBL bl = new CRBL(new FileRepo());
        switch (menuString)
        {
            case "main":
                return new MainMenu(bl);

            case "storefront":
                return new StorefrontMenu(bl);

            default:
                return new MainMenu(bl);
        }
    }
}