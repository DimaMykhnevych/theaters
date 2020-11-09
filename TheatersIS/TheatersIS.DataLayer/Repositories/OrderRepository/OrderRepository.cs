using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.OrderRepositoryN
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(TheaterDbContext context) : base(context) { }
    }
}
