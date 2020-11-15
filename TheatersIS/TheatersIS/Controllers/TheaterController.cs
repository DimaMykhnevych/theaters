using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.TheaterService;

namespace TheatersIS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TheaterController : ControllerBase
    {
        private readonly ITheaterService _theaterService;
        public TheaterController(ITheaterService theaterService)
        {
            _theaterService = theaterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTheaters([FromQuery] SearchTheraterDTO parameters)
        {
            IEnumerable<TheaterDTO> theaters = await _theaterService.SearchTheaters(parameters);
            return Ok(theaters);
        }

        [HttpGet("{id}")]
        public IActionResult GetTheater(int id)
        {
            var theater = _theaterService.GetTheater(id);
            if (theater == null)
                return NotFound();
            return Ok(theater);
        }

        [HttpPost]
        public IActionResult AddTheaterAndAddress([FromBody] TheaterDTO addTheaterDTO)
        {
            var added = _theaterService.AddTheater(addTheaterDTO);
            if (added == null)
                return BadRequest();
            return Ok(added);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTheater(int id)
        {
            bool deleted = _theaterService.DeleteTheater(id);
            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTheater(int id, TheaterDTO theaterDTO)
        {
            var updatedTheater = await _theaterService.UpdateTheater(id, theaterDTO);
            if (updatedTheater == null)
                return NotFound();
            return Ok(updatedTheater);
        }
    }
}
