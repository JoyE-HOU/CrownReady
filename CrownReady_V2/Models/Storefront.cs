using CustomExceptions;
using System.Text.RegularExpressions;

// To create models folder, run: dotnet new classlib -n "Models"  
namespace Models;

public class Storefront {
    public int Id { get; set; }

    // public string? Name { get; set; }
    // Error: string Storefront.Name { get; set; }: Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable. [CrownReady_V2]csharp(CS8618)
    // Solutions:
    // public string? Name { get; set;} or public string Name { get; set;} = "CrownReady" (Best solution)
    // public string Name { get; set; } = "CrownReady"; (May trigger this error: warning CS8601: Possible null reference assignment.)

    private string? _name;
    public string? Name {
        get => _name;
        set
        {
            Regex pattern = new Regex("^[a-zA-Z0-9 !?-]+$");
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Name can't be empty");
            }
            else if(!pattern.IsMatch(value))
            {
                throw new InputInvalidException("Storefront name can only include alphanumeric characters, white space, -, ?, or !");
            }
            else
            {
                this._name = value;
            }
        }
    }
    // public string? Address { get; set; }
    private string? _address;
    public string? Address
    {
        get => _address;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Address can't be empty");
            }
            else
            {
                this._address = value;
            }
            
        }
    }
    // public string? City { get; set; }
    private string? _city;
    public string? City
    {
        get => _city;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                {
                    throw new InputInvalidException("City can't be empty");
                }
            else
            {
                this._city = value;
            }
        }
    }
    // public string? State { get; set; }
    private string? _state;
    public string? State
    {
        get => _state;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("State can't be empty");
            }
            else
            {
                this._state = value;
            }
        }
    }
    public List<Inventory>? Inventories { get; set; }
    public List<Order>? Orders { get; set; }

    // override ToString method
    public override string ToString()
    {
        return $"Store: {this.Name} \nAddress: {this.Address} \nCity: {this.City} \nState: {this.State}";
    }
}