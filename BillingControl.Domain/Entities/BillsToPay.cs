namespace BillingControl.Domain.Entities;

public class BillsToPay : Entity
{
    public string? Description { get; set; }
    public decimal Value { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool PaidOut { get; set; } = false;
    public Customers? Supplier { get; set; }
}
