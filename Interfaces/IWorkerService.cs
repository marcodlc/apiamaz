using ApiAmaz.Model;

namespace ApiAmaz.Interfaces;
public interface IWorkerService
{
    IEnumerable<Worker> Get();
    Task Save(Worker worker);
    Task Update(Worker worker,Guid Code);
    Task Delete(Guid Code);
}