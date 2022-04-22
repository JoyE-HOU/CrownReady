using System.Text.Json;
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
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Storefront>>(jsonString);
    }
    /// <summary>
    /// Adds a new storefront to the list
    /// </summary>
    /// <param name="storefront"> storefront object to be added</param>
    public void AddStorefront(Storefront storefrontToAdd)
    {
        List<Storefront> allStorefronts = GetAllStorefronts();
        allStorefronts.Add(storefrontToAdd);

        string jsonString = JsonSerializer.Serialize(allStorefronts);
        File.WriteAllText(filePath, jsonString);
    }
/// <summary>
/// Finds and returns storefront by its index
/// </summary>
/// <param name="index">index to search storefronts for</param>
/// <returns>storefront object</returns>
    public Storefront GetStorefrontByIndex (int index)
    {
        List<Storefront> allStorefronts = GetAllStorefronts();
        return allStorefronts[index];
    }
}