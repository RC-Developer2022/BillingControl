using BillingControl.Domain.Entities;
using BillingControl.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BillingControl.Infrastructure.Repository.Services;

public class ServersRepository : IServersRepository
{
    private readonly AppDbContext context = new AppDbContext();
    public async Task<IEnumerable<Servers>> GetAllServers()
    {
        var servers = await context.Servidores.ToListAsync();
        context.Dispose();
        return servers;
    }

    public async Task<IEnumerable<Servers>> GetNameServers(string name)
    {
        var servers = await context.Servidores.Where(s => s.Name.StartsWith(name)).ToListAsync();
        context.Dispose();
        return servers;
    }

    public async Task<Servers> GetIdServers(Guid id)
    {
        var server = await context.Servidores.Where(s => s.Id.Equals(id)).FirstOrDefaultAsync();
        context.Dispose();
        return server;
    }

    
}
