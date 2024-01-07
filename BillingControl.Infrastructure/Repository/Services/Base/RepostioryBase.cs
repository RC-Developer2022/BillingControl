using BillingControl.Domain;
using BillingControl.Infrastructure.Repository.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BillingControl.Infrastructure.Repository.Services.Base;

public class RepostioryBase<T> : IRepositoryBase<T> where T : Entity
{
    
    public async Task AddAsync(T entity)
    {
        using (var context = new AppDbContext()) 
        {
            await context.AddAsync(entity);
        }
    }

    public async Task DeleteAsync(T entity)
    {
        using (var context = new AppDbContext())
        {
            context.Remove(entity);
        }
    }

    public async Task UpdateAsync(T entity)
    {
        using (var context = new AppDbContext())
        {
            context.Update(entity);
        }
    }
}
