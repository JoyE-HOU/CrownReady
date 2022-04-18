namespace DL;

public class FileRepo
{
    public FileRepo()
    { }
    private string filePath = "../DL/Storefronts.json";
    /// <summary>
    /// Returns all storefronts
    /// </summary>
    /// <returns>all storefront in the list</returns>
    public List<Storefront> GetAllStorefronts()
    {
        // returns all storefronts written in the file
        return new List<Storefront>();
        string jsonString = File.ReadAllText(filePath);
    }
    /// <summary>
    /// Adds a new storefront to the list
    /// </summary>
    /// <param name="storefront"> storefront object to be added</param>
    public void AddStorefront(Storefront storefrontToAdd)
    {
        // adds a new storefront
    }
}