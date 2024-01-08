using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BillingControl.Infrastructure.Repository.Services;

public class AccountReceiveRepository : IAccountReceiveRepository
{
    private readonly AppDbContext context = new AppDbContext();
    public async Task<IEnumerable<AccountReceive>> GetAllAccountReceives()
    {
        var accounts = (IEnumerable<AccountReceive>)
            await context.ContasAReceber.ToListAsync();

        context.Dispose();
        return accounts;
    }

    public async Task<IEnumerable<AccountReceive>> GetValueAccountReceives(decimal value)
    {
        var accounts = (IEnumerable<AccountReceive>) await context.ContasAReceber.Where(a => a.Value.Equals(value)).ToListAsync();
        context.Dispose();
        return accounts;
    }

    public async Task<IEnumerable<AccountReceive>> GetExpiryDateAccountReceives(DateTime expiryDate)
    {
        var accounts = (IEnumerable<AccountReceive>) await context.ContasAReceber.Where(a => a.ExpiryDate.Equals(expiryDate)).ToListAsync();
        context.Dispose();
        return accounts;
    }

    public async Task<AccountReceive> GetCustomerAccountReceives(Guid customerId)
    {
        var account = await context.ContasAReceber
                .Where(a => a.Cliente.Id.Equals(customerId)).FirstOrDefaultAsync();

        context.Dispose();
        return account;
    }
}
