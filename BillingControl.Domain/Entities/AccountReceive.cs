namespace BillingControl.Domain.Entities;

public class AccountReceive : Entity
{
    public string? Description { get; set; }
    public decimal Value { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool Received { get; set; } = false;
    public Customers? Cliente { get; set; }
}
