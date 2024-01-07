using BillingControl.Domain.Entities;

namespace BillingControl.Infrastructure.Repository.Interfaces;

public interface IServersRepository
{
    Task<IEnumerable<Servers>> GetAllServers();
    Task<IEnumerable<Servers>> GetNameServers(string name);
    Task<Servers> GetIdServers(Guid id);
}
