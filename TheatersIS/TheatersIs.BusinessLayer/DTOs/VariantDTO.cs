using System.Collections.Generic;

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
