using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class TheaterDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TheaterTypes TheaterType { get; set; }

        [Required]
        public int AddressId { get; set; }

        public AddressDTO Address { get; set; }
    }
}
