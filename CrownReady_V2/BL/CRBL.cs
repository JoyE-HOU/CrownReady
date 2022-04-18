// first add `using Models`;
using Models;
// then add reference `dotnet add reference ../Models`; repeat steps for DL
using DL;
namespace BL;
public class CRBL
{
    /// <summary>
    /// Gets all storefronts
    /// </summary>
    /// <returns></returns>
    public List<Storefront> GetAllStorefronts()
    {
        return StaticStorage.GetAllStorefronts();
    }
    /// <summary>
    /// Adds a new storefront to the list
    /// </summary>
    /// <param name="storefront">storefront object to add</param>
    public void AddStorefront(Storefront storefrontToAdd)
    {
        StaticStorage.AddStorefront(storefrontToAdd);
    }
}
