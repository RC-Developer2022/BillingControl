using BillingControl.Domain.Entities;

namespace BillingControl.Application.Repository.Interfaces;

public interface ICustomersApplication
{
    Task<IEnumerable<Customers>> GetAllCustomers();
    Task<IEnumerable<Customers>> GetNameCustomers(string name);
    Task<Customers> GetIdCustomers(Guid id);
    Task AddCustomer(Customers customer);
    Task UpdateCustomer(Customers customer);
    Task DeleteCustomer(Guid id);
    
}
