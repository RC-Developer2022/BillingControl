using BillingControl.Domain.Entities;

namespace BillingControl.Application.Repository.Interfaces;

public interface IAccountReceiveApplication
{
    Task<IEnumerable<AccountReceive>> GetAllAccountReceives();
    Task<IEnumerable<AccountReceive>> GetValueAccountReceives(decimal value);
    Task<IEnumerable<AccountReceive>> GetExpiryDateAccountReceives(DateTime expiryDate);
    Task<AccountReceive> GetCustomerAccountReceives(Guid customerId);
    Task AddAsync(AccountReceive accountReceive);
    Task UpdateAsync(AccountReceive accountReceive);
    Task DeleteAsync(Guid accountId);
}
