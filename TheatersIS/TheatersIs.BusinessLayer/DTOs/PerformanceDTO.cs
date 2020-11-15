using System.ComponentModel.DataAnnotations;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class PerformanceDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public PerformanceStatus PerformanceStatus { get; set; }

        [Required]
        public PerformanceGenre PerformanceGenre { get; set; }

        public string Author { get; set; }
        public string Composer { get; set; }

        //public List<TheaterPerformanceDTO> TheaterPerformances { get; set; }
    }
}
