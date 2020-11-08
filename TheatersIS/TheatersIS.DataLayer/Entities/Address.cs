using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        [Required]
        public string StreetName { get; set; }

        public Theater Theater { get; set; }
    }
}
