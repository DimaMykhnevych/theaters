using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.OrderService
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetOrders();
        Task<AllOrderInfoDTO> GetOrder(int id);
        Task<OrderDTO> AddOrder(OrderDTO order);

        Task<bool> DeleteOrder(int id);
    }
}
