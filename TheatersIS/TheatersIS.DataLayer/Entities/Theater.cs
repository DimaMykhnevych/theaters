using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class Theater
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TheaterTypes TheaterType { get; set; }

        [Required]
        public int AddressId { get; set; }



        public Address Address { get; set; }

        public List<TheaterPerformance> TheaterPerformances { get; set; }
    }
}
