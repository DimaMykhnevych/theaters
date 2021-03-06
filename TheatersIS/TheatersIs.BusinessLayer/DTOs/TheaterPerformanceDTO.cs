﻿using System;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class TheaterPerformanceDTO
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int PerformanceId { get; set; }
        public DateTime PerformanceDate { get; set; }
        public decimal TicketPrice { get; set; }


        public TheaterDTO Theater { get; set; }
        public PerformanceDTO Performance { get; set; }

        //public List<OrderDTO> Orders { get; set; }
    }
}
