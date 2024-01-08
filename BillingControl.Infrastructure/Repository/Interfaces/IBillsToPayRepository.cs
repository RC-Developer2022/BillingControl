using BillingControl.Domain.Entities;

namespace BillingControl.Infrastructure.Repository.Interfaces;

public interface IBillsToPayRepository
{
    Task<IEnumerable<BillsToPay>> GetAllBillsToPay();
    Task<IEnumerable<BillsToPay>> GetValueBillsToPay(decimal value);
    Task<IEnumerable<BillsToPay>> GetExpiryDateBillsToPay(DateTime expiryDate);
    Task<BillsToPay> GetSupplierBillsToPay(Guid customerId);
}
