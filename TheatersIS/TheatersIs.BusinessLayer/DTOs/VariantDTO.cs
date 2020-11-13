using System;
using System.Collections.Generic;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class VariantDTO
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string VariantText { get; set; }

        public List<UserAnswerDTO> UserAnswers { get; set; }
    }
}
