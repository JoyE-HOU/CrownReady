namespace BL;
public interface IBL
{
    // Storefront SearchStorefronts (string searchString);

    List<Storefront> GetAllStorefronts();
    void AddStorefront(Storefront storefrontToAdd);
}