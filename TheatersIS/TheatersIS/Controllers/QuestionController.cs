using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.QuestionService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestions()
        {
            IEnumerable<QuestionDTO> questions = await _questionService.GetQuestions();
            return Ok(questions);
        }
    }
}
