using ApiAmaz.Data;
using ApiAmaz.Interfaces;
using ApiAmaz.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiAmaz.Services;

public class WorkerService : IWorkerService
{
    AmazDbContext context;

    public WorkerService(AmazDbContext dbContext)
    {
        context = dbContext;
    }
    public async Task Delete(Guid Code)
    {
        var current = context.Workers.Find(Code);

        if(current != null)
        {
            context.Remove(current);
            await context.SaveChangesAsync();
        } 
    }

    public IEnumerable<Worker> Get()
    {
        return context.Workers.Include(p => p.Role);
    }

    public async Task Save(Worker worker)
    {
        context.Add(worker);
        await context.SaveChangesAsync();
    }

    public async Task Update(Worker worker, Guid Code)
    {
        var current = context.Workers.Find(Code);
        
        if(current != null){
            
            current.Name = worker.Name;
            current.RoleCode = worker.RoleCode;
            current.isActive = worker.isActive;
            current.Email = worker.Email;
            current.Updater = worker.Updater;
            await context.SaveChangesAsync();
        }
    }
}