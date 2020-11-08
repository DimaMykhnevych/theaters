using System;
using System.Collections.Generic;

namespace TheatersIS.DataLayer.Entities
{
    public class TheaterPerformance
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int PerformanceId { get; set; }
        public DateTime PerformanceDate { get; set; }
        public decimal TicketPrice { get; set; }



        public Theater Theater { get; set; }
        public Performance Performance { get; set; }

        public List<Order> Orders { get; set; }
    }
}
