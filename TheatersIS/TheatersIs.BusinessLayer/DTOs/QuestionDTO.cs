using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }


        [Required]
        public string Text { get; set; }

        public List<VariantDTO> Variants { get; set; }
    }
}
