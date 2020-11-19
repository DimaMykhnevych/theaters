using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN;

namespace TheatersIs.BusinessLayer.Services.UserAnswerService
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;


        private readonly IMapper _mapper;


        public UserAnswerService(IUserAnswerRepository userAnswerRepository,
            IMapper mapper)
        {
            _userAnswerRepository = userAnswerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserAnswerDTO>> GetUserAnswers()
        {
            IEnumerable<UserAnswer> userAnswers = _userAnswerRepository.GetAll();
            return _mapper.Map<IEnumerable<UserAnswerDTO>>(userAnswers);
        }
        public async Task<IEnumerable<UserAnswerDTO>> AddUserAnswers(IEnumerable<UserAnswerDTO> userAnswerDTOs)
        {
            IEnumerable<UserAnswer> answers = _mapper.Map<IEnumerable<UserAnswer>>(userAnswerDTOs);

            foreach(var a in answers)
            {
                _userAnswerRepository.Insert(a);
            }

            _userAnswerRepository.Save();

            return _mapper.Map<IEnumerable<UserAnswerDTO>>(answers);
        }

        public async Task<bool> DeleteUserAnswer(int id)
        {
            UserAnswer answerToDelete = _userAnswerRepository.Get(id);
            if (answerToDelete == null)
                return false;
            _userAnswerRepository.Delete(answerToDelete);
            _userAnswerRepository.Save();
            return true;
        }
    }
}
