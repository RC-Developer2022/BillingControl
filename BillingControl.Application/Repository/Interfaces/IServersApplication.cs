using BillingControl.Domain.Entities;

namespace BillingControl.Application.Repository.Interfaces;

public interface IServersApplication
{
    Task<IEnumerable<Servers>> GetAllServers();
    Task<IEnumerable<Servers>> GetNameServers(string name);
    Task<Servers> GetIdServers(Guid id);

    Task AddServer(Servers server);
    Task UpdateServer(Servers server);
    Task DeleteServer(Guid id);
}
