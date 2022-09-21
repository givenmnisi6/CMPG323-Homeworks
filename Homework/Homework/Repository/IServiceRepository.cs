using Homework.Models;

namespace Homework.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }

}
