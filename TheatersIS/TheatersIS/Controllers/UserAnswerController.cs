using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.UserAnswerService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {
        private readonly IUserAnswerService _userAnswerService;
        public UserAnswerController(IUserAnswerService userAnswerService)
        {
            _userAnswerService = userAnswerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAnswers()
        {
            IEnumerable<UserAnswerDTO> answers = await _userAnswerService.GetUserAnswers();
            return Ok(answers);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAnswer([FromBody] IEnumerable<UserAnswerDTO> userAnswerDTOs)
        {
            IEnumerable<UserAnswerDTO> added = await _userAnswerService.AddUserAnswers(userAnswerDTOs);
            if (added == null)
                return BadRequest();
            return Ok(added);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAnswer(int id)
        {
            bool deleted = await _userAnswerService.DeleteUserAnswer(id);
            return Ok(deleted);
        }
    }
}
