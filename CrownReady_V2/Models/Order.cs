namespace Models;

public class Order {
    public int Id { get; set; }
    public DateTime OrderDate { get; set;}
    public int OrderNumber { get; set; }
    public User? CustomerInfo { get; set;}
    public Storefront? StorefrontInfo { get; set; }
    public List<LineItem>? LineItems { get; set; }
    public decimal Total { get; set; }

    public decimal CalculateTotal() {
        // a method to calculate all line items in order
        decimal total = 0;
        if(this.LineItems?.Count > 0)
        {
            foreach (LineItem lineItem in this.LineItems)
            {
                total =+ lineItem.Item.Price * lineItem.Quantity;
            }
        }
        this.Total = total;
        return total;
    }
}