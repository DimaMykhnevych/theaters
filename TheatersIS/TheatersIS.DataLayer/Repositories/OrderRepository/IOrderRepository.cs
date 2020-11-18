using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.OrderRepositoryN
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetAllOrderInfoById(int id);
    }
}
