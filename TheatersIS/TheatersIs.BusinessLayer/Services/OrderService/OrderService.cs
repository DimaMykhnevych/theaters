using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.EmailService;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.OrderRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.UserRepositoryN;

namespace TheatersIs.BusinessLayer.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITheaterPerformanceRepository _theaterPerformanceRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository,
            IUserRepository userRepository,
            ITheaterPerformanceRepository theaterPerformanceRepository,
            IEmailService emailService,
         IMapper mapper)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _theaterPerformanceRepository = theaterPerformanceRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            return _mapper.Map<IEnumerable<OrderDTO>>(_orderRepository.GetAll());
        }

        public async Task<AllOrderInfoDTO> GetOrder(int id)
        {
            Order orderInfo = await _orderRepository.GetAllOrderInfoById(id);
            return _mapper.Map<AllOrderInfoDTO>(orderInfo);
        }

        public async Task<OrderDTO> AddOrder(OrderDTO orderDTO)
        {
            Order order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Insert(order);
            _orderRepository.Save();

            // get user email by user id
            UserDTO user = _mapper.Map<UserDTO>( _userRepository.Get(order.UserId));
            // get all needed info for ticket and create separate DTO with this ubfi inky
            EmailTicketInfoDTO emailTicketInfo = new EmailTicketInfoDTO
            {
                Order = _mapper.Map<OrderDTO>(order),
                TheaterPerformance = 
                 _mapper.Map<TheaterPerformanceDTO>
                 (await _theaterPerformanceRepository
                 .GetTheaterPerformanceWithOrdersAndAddressById(order.TheaterPerformanceId)),
            };

            await _emailService.SendTicketEmail(emailTicketInfo, user);


            return _mapper.Map<OrderDTO>(order);
        }

        public async Task<bool> DeleteOrder(int id)
        {
            Order orderToDelete = _orderRepository.Get(id);
            if (orderToDelete == null)
                return false;
            _orderRepository.Delete(orderToDelete);
            _orderRepository.Save();
            return true;
        }


    }
}
