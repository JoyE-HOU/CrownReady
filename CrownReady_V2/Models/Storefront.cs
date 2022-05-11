// To create models folder, run: dotnet new classlib -n "Models"  
namespace Models;

public class Storefront {
    public int Id { get; set; }
    public string? Name { get; set; }
    // Error: string Storefront.Name { get; set; }: Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable. [CrownReady_V2]csharp(CS8618)
    // Solutions:
    // public string? Name { get; set;} or public string Name { get; set;} = "CrownReady" (Best solution)
    // public string Name { get; set; } = "CrownReady"; (May trigger this error: warning CS8601: Possible null reference assignment.)
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }

    // override ToString method
    public override string ToString()
    {
        return $"Store: {this.Name} \nAddress: {this.Address} \nCity: {this.City} \nState: {this.State}";
    }
}