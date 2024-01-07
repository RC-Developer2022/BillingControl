using BillingControl.Domain;

namespace BillingControl.Infrastructure.Repository.Interfaces.Base;

public interface IRepositoryBase<T> where T : Entity
{
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
}
