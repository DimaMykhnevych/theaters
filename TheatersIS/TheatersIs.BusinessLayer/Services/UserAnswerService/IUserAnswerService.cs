using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.UserAnswerService
{
    public interface IUserAnswerService
    {
        Task<IEnumerable<UserAnswerDTO>> GetUserAnswers();
        Task<IEnumerable<UserAnswerDTO>> AddUserAnswers(IEnumerable<UserAnswerDTO> userAnswerDTOs);
        Task<bool> DeleteUserAnswer(int id);
    }
}
