using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace BillingControl.Infrastructure.Repository.Services;

public class BillsToPayRepository : IBillsToPayRepository
{
    private readonly AppDbContext _context = new AppDbContext();

    public async Task<IEnumerable<BillsToPay>> GetAllBillsToPay()
    {
        var billsToPays = (IEnumerable<BillsToPay>) await _context.ContasAPagar.ToListAsync();
        _context.Dispose();
        return billsToPays;
    }

    public async Task<IEnumerable<BillsToPay>> GetValueBillsToPay(decimal value)
    {
        var billsToPays = (IEnumerable<BillsToPay>) await _context.ContasAPagar.Where(b => b.Value.Equals(value)).ToListAsync();
        _context.Dispose();
        return billsToPays;
    }

    public async Task<IEnumerable<BillsToPay>> GetExpiryDateBillsToPay(DateTime expiryDate)
    {
        var billsToPays = (IEnumerable<BillsToPay>) await _context.ContasAPagar.Where(b => b.ExpiryDate.Equals(expiryDate)).ToListAsync();
        _context.Dispose();
        return billsToPays;
    }

    public async Task<BillsToPay> GetSupplierBillsToPay(Guid supplierId)
    {
        var billsToPay = await _context.ContasAPagar.Where(b => b.Supplier.Id.Equals(supplierId)).FirstOrDefaultAsync();
        _context.Dispose();
        return billsToPay;
    }
}
