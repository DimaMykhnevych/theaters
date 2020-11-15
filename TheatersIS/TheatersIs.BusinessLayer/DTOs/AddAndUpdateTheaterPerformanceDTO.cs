using System;
using System.Collections.Generic;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class AddAndUpdateTheaterPerformanceDTO
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int PerformanceId { get; set; }
        public DateTime PerformanceDate { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
