using BillingControl.Domain.Entities;

namespace BillingControl.Infrastructure.Repository.Interfaces;

public interface IAccountReceiveRepository
{
    Task<IEnumerable<AccountReceive>> GetAllAccountReceives();
    Task<IEnumerable<AccountReceive>> GetValueAccountReceives(decimal value);
    Task<IEnumerable<AccountReceive>> GetExpiryDateAccountReceives(DateTime expiryDate);
    Task<AccountReceive> GetCustomerAccountReceives(Guid customerId);
}
