using System.ComponentModel.DataAnnotations;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class OrderDTO
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
