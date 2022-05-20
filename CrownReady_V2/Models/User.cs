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
    public string? Address {get; set;}
    public string? City {get; set;}
    public string? State {get; set;}
    public int ZipCode {get; set;}
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