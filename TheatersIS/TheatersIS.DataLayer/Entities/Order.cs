using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TheaterPerformanceId { get; set; }

        [Required]
        public int TicketsAmount { get; set; }

        public User User { get; set; }

        public TheaterPerformance TheaterPerformance { get; set; }
    }
}
