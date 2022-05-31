using CustomExceptions;
using System.Text.RegularExpressions;
namespace Models;
public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public void DisplayName(){
        Console.WriteLine($"{this.FirstName} {this.LastName}");
    }
    public virtual void DisplayType(){
        // Console.WriteLine("Default displaying user type method");
    }
}
public class Customer : User {
    // example of inheritance
    public string UserType = "Customer";
    // public string? Address {get; set;}
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
    // public string? City {get; set;}
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
    // public string? State {get; set;}
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
    // public int ZipCode {get; set;}
    private string? _zipCode;
    public string? ZipCode
    {
        get => _zipCode;
        set
        {
            Regex pattern = new Regex("^[0-9]");
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Zip Code can't be empty");
            }
            else if(value.Length < 5 | value.Length > 5)
            {
                throw new InputInvalidException("Zip code can only have 5 digits");
            }
            else if(!pattern.IsMatch(value))
            {
                throw new InputInvalidException("Zip code can only include numbers");
            }
            else
            {
                this._zipCode = value;
            }
        }
    }
    public List<Order>? Orders { get; set; }
    public override void DisplayType(){
        Console.WriteLine(UserType);
    }
}
public class Employee : User {}
public class Associate : Employee 
{
    public string UserType = "Associate";
    public override void DisplayType(){
        Console.WriteLine(UserType);
    }
}
public class Manager: Employee 
{
    public string UserType = "Manager";
    public override void DisplayType(){
        Console.WriteLine(UserType);
    }
}