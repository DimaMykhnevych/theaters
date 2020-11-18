using System.Threading.Tasks;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TheatersIS.DataLayer.Repositories.OrderRepositoryN
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(TheaterDbContext context) : base(context) { }

        public async Task<Order> GetAllOrderInfoById(int id)
        {
            return Context.Orders
                .Include(o => o.User)
                .Include(o => o.TheaterPerformance.Performance)
                .Include(o => o.TheaterPerformance)
                .ThenInclude(tp => tp.Theater.Address)
                .FirstOrDefault(o => o.Id == id);
        }
    }
}
