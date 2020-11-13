using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class UserAnswerDTO
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int VariantId { get; set; }


        public UserDTO User { get; set; }

        public VariantDTO Variant { get; set; }
    }
}
