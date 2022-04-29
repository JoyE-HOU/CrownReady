// first add `using Models`;
// using Models;
// then add reference `dotnet add reference ../Models`; repeat steps for DL
// using DL;
namespace BL;
public class CRBL : IBL
{
    private IRepo _dl;
    public CRBL(IRepo repo){
        _dl = repo;
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

    // public Storefront SearchStorefront (string searchString)
    // {
        
    // }
}
