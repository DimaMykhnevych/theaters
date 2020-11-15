using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.TheaterPerformanceService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterPerformanceController : ControllerBase
    {
        private readonly ITheaterPerformanceService _theaterPerformanceService;
        public TheaterPerformanceController(ITheaterPerformanceService theaterPerformanceService)
        {
            _theaterPerformanceService = theaterPerformanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTheaterPerformances
            ([FromQuery] SearchTheaterPerformanceDTO parameters)
        {
            IEnumerable<TheaterPerformanceDTO> performances =
                await _theaterPerformanceService.SearchTheaterPerformances(parameters);
            return Ok(performances);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTheaterPerformance(int id)
        {
            TheaterPerformanceDTO theaterPerformance =
                await _theaterPerformanceService.GetTheaterPerformance(id);
            if (theaterPerformance == null)
                return NotFound();
            return Ok(theaterPerformance);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerformance
            ([FromBody] AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            var added = await _theaterPerformanceService.AddTheaterPerformance(theaterPerformanceDTO);
            if (added == null)
                return BadRequest();
            return Ok(added);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheaterPerformance(int id)
        {
            bool deleted = await _theaterPerformanceService.DeleteTheaterPerformance(id);
            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTheaterPerformance
            (int id, AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            var updatedTheaterPerformance =
                await _theaterPerformanceService.UpdateTheaterPerformance(id, theaterPerformanceDTO);
            if (updatedTheaterPerformance == null)
                return NotFound();
            return Ok(updatedTheaterPerformance);
        }
    }
}
