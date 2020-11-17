using System;
using System.Collections.Generic;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class TicketSalesDTO
    {
        public int Id { get; set; }
        public decimal Revenue { get; set; }
        public string TheaterName { get; set; }
        public DateTime? StartDate { get; set; }
        public  DateTime? EndDate { get; set; }
    }
}
