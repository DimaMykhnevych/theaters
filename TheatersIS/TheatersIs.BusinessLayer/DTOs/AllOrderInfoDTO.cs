using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class AllOrderInfoDTO
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TheaterPerformanceId { get; set; }

        [Required]
        public int TicketsAmount { get; set; }

        public UserDTO User { get; set; }

        public TheaterPerformanceDTO TheaterPerformance { get; set; }
    }
}
