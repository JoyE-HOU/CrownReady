// using Models;
namespace DL;
public class StaticStorage : IRepo
{
    private static List<Storefront> _allStorefronts = new List<Storefront>();
    // private static List<Storefront> _allStorefronts = new List<Storefront>();
    /// <summary>
    /// Returns all storefronts from _allStorefronts in the list 
    /// </summary>
    /// <returns>all storefronts in the list</returns>
    public List<Storefront> GetAllStorefronts()
    
    // public static List<Storefront> GetAllStorefronts()
    {
        return StaticStorage._allStorefronts;
    }
    /// <summary>
    /// Adds a new storefront to the list
    /// </summary>
    /// <param name="storefrontToAdd">new storefront object to list</param>
    public void AddStorefront(Storefront storefrontToAdd)
    // public static void AddStorefront(Storefront storefrontToAdd)
    {
        StaticStorage._allStorefronts.Add(storefrontToAdd);
    }
}
