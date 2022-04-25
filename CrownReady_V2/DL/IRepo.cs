namespace DL;
public interface IRepo
{
    List<Storefront> GetAllStorefronts();
    void AddStorefront( Storefront storefrontToAdd);
}