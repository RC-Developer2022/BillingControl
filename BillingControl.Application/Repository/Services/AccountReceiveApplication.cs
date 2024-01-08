using BillingControl.Application.Repository.Interfaces;
using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Services;
using BillingControl.Infrastructure.Repository.Services.Base;

namespace BillingControl.Application.Repository.Services;

public class AccountReceiveApplication : IAccountReceiveApplication
{
    private readonly AccountReceiveRepository _accountReceiveRepository = new AccountReceiveRepository();
    private readonly RepostioryBase<AccountReceive> _repository = new RepostioryBase<AccountReceive>();
    public Task<IEnumerable<AccountReceive>> GetAllAccountReceives()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AccountReceive>> GetValueAccountReceives(decimal value)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AccountReceive>> GetExpiryDateAccountReceives(DateTime expiryDate)
    {
        throw new NotImplementedException();
    }

    public Task<AccountReceive> GetCustomerAccountReceives(Guid customerId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(AccountReceive accountReceive)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(AccountReceive accountReceive)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid accountId)
    {
        throw new NotImplementedException();
    }
    
}
