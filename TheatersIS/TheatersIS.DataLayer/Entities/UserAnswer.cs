using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIS.DataLayer.Entities
{
    public class UserAnswer
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int VariantId { get; set; }


        public User User { get; set; }

        public Variant Variant { get; set; }


    }
}
