namespace Models;
public class Order {
    public int Id { get; set; }
    public int OrderNumber { get; set; }
    public datetime OrderDate { get; set; }
    public decimal Total { get; set; }
    public bool IfPlaced { get; set; }
}