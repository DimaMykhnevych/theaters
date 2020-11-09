using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class AddressDTO
    {
        public int Id { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        [Required]
        public string StreetName { get; set; }
    }
}
