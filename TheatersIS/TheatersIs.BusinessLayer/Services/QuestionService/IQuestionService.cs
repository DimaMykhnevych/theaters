using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.QuestionService
{
    public interface IQuestionService
    {
        Task<IEnumerable<QuestionDTO>> GetQuestions();
    }
}
