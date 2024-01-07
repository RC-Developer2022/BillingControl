using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BillingControl.Infrastructure.Repository.Services;

public class CustomersRepository : ICustomersRepository
{
    public async Task<IEnumerable<Customers>> GetAllCustomers()
    {
        using (var context = new AppDbContext()) 
        {
            return await context.Clientes.ToListAsync();
        }
    }

    public async Task<IEnumerable<Customers>> GetNameCustomers(string name)
    {
        using (var context = new AppDbContext())
        {
            return await context.Clientes.Where(c => c.Name.StartsWith(name)).ToListAsync();
        }
    }

    public async Task<Customers> GetIdCustomers(Guid id)
    {
        using (var context = new AppDbContext())
        { 
            return await context.Clientes.Where(c => c.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }

   
}
