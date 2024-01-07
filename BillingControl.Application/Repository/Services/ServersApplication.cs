using BillingControl.Application.Repository.Interfaces;
using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Services;
using BillingControl.Infrastructure.Repository.Services.Base;

namespace BillingControl.Application.Repository.Services;

public class ServersApplication : IServersApplication
{
    private readonly ServersRepository _serversRepository = new ServersRepository();
    private readonly RepostioryBase<Servers> _repostiory = new RepostioryBase<Servers>();
    public async Task<IEnumerable<Servers>> GetAllServers()
    {
        try
        {
            var servers = await _serversRepository.GetAllServers();
            return servers;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<IEnumerable<Servers>> GetNameServers(string name)
    {
        try
        {
            var servers = await _serversRepository.GetNameServers(name);
            return servers;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Servers> GetIdServers(Guid id)
    {
        try
        {
            var server = await _serversRepository.GetIdServers(id);

            return server;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task AddServer(Servers server)
    {
        try
        {
            await _repostiory.AddAsync(server);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task UpdateServer(Servers server)
    {
        try
        {
            await _repostiory.UpdateAsync(server);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task DeleteServer(Guid id)
    {
        try
        {
            var server = await _serversRepository.GetIdServers(id);
            await _repostiory.DeleteAsync(server);
        }
        catch (Exception)
        {

            throw;
        }
    }
}
