using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class Question
    {
        public int Id { get; set; }


        [Required]
        public string Text { get; set; }

        public List<Variant> Variants { get; set; }
    }
}
