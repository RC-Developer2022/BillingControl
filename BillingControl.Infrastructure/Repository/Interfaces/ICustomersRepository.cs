using BillingControl.Domain.Entities;

namespace BillingControl.Infrastructure.Repository.Interfaces;

public interface ICustomersRepository
{
    Task<IEnumerable<Customers>> GetAllCustomers();
    Task<IEnumerable<Customers>> GetNameCustomers(string name);
    Task<Customers> GetIdCustomers(Guid id);

}
