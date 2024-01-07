namespace BillingControl.Infrastructure.UnitOfWork;

public class UnitOfWork
{
    public async Task<bool> Commit() 
    {
        using (var context = new AppDbContext())
        {
            return await context.SaveChangesAsync() > 0;
        }
    }

    public Task Roolback() 
    {
        return Task.CompletedTask;
    }
}
