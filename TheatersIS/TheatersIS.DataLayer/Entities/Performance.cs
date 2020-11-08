using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class Performance
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

        public List<TheaterPerformance> TheaterPerformances { get; set; }
    }
}
