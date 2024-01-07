using BillingControl.Application.Repository.Interfaces;
using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Services;
using BillingControl.Infrastructure.Repository.Services.Base;

namespace BillingControl.Application.Repository.Services;

public class CustomersApplication : ICustomersApplication
{
    private readonly CustomersRepository _customersRepository = new CustomersRepository();
    private readonly RepostioryBase<Customers> _repostiory = new RepostioryBase<Customers>();
    public async Task<IEnumerable<Customers>> GetAllCustomers()
    {
        try
        {
            var customers = await _customersRepository.GetAllCustomers();

            return customers;
        }
        catch (Exception)
        { 
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> GetNameCustomers(string name)
    {
        try
        {
            var customers = await _customersRepository.GetNameCustomers(name);
            
            return customers;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Customers> GetIdCustomers(Guid id)
    {
        try
        {
            var customer  =  await _customersRepository.GetIdCustomers(id);

            return customer;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task AddCustomer(Customers customer)
    {
        try
        {
            await _repostiory.AddAsync(customer);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task UpdateCustomer(Customers customer)
    {
        try
        {
            await _repostiory.UpdateAsync(customer);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task DeleteCustomer(Guid id)
    {
        try
        {
            var customer = await _customersRepository.GetIdCustomers(id);
            await _repostiory.DeleteAsync(customer);
        }
        catch (Exception)
        {

            throw;
        }
    } 
}
