using System.Collections.Generic;

namespace TheatersIS.DataLayer.Entities
{
    public class Variant
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string VariantText { get; set; }

        public List<UserAnswer> UserAnswers { get; set; }
    }
}
