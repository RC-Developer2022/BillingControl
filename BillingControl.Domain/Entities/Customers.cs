namespace BillingControl.Domain.Entities;

public sealed class Customers : Entity
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string? Recommendation { get; set; }
    public string? Observation { get; set; }
    public Decimal? Discount { get; set; }

    public Customers() {}

    public Customers(string name, string phone, DateTime expiryDate)
    {
        Name = name;
        Phone = phone;
        ExpiryDate = expiryDate;
    }
}
