// first add `using Models`;
using Models;
// then add reference `dotnet add reference ../Models`; repeat steps for DL
using DL;
namespace BL;
public class CRBL
{
    private FileRepo _dl;
    public CRBL(){
        _dl = new FileRepo();
    }
    /// <summary>
    /// Gets all storefronts
    /// </summary>
    /// <returns></returns>
    public List<Storefront> GetAllStorefronts()
    {
        return _dl.GetAllStorefronts();
    }
    /// <summary>
    /// Adds a new storefront to the list
    /// </summary>
    /// <param name="storefront">storefront object to add</param>
    public void AddStorefront(Storefront storefrontToAdd)
    {
        _dl.AddStorefront(storefrontToAdd);
    }
}
