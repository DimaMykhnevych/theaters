using System;
using System.Collections.Generic;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class EmailTicketInfoDTO
    {
        public TheaterPerformanceDTO TheaterPerformance { get; set; }
        public OrderDTO Order { get; set; }

    }
}
