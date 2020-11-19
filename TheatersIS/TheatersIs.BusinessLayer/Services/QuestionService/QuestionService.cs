using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.QuestionRepositoryN;

namespace TheatersIs.BusinessLayer.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;


        private readonly IMapper _mapper;


        public QuestionService(IQuestionRepository questionRepository,
            IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<QuestionDTO>> GetQuestions()
        {
            IEnumerable<Question> questions = _questionRepository.GetAll();
            return _mapper.Map<IEnumerable<QuestionDTO>>(questions);
        }
    }
}
