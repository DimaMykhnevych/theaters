using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }


        [Required]
        public string Text { get; set; }

        //public List<VariantDTO> Variants { get; set; }
    }
}
