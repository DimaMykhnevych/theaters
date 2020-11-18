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

        [HttpGet("attendanceTheaters")]
        public async Task<IActionResult> GetTheaterAttendance()
        {
            IEnumerable<TheaterAttendanceDTO> res = 
                await _theaterPerformanceService.GetTheaterPerformancesWithOrders();
            return Ok(res);
        }

        [HttpGet("mostPopularTheaters")]
        public async Task<IActionResult> GetMostPopularTheaters()
        {
            IEnumerable<TheaterAttendanceDTO> res =
                await _theaterPerformanceService.GetMostPopularTheaters();
            return Ok(res);
        }

        [HttpGet("mostUnpopularTheaters")]
        public async Task<IActionResult> GetMostUnpopularTheaters()
        {
            IEnumerable<TheaterAttendanceDTO> res =
                await _theaterPerformanceService.GetMostUnpopularTheaters();
            return Ok(res);
        }

        [HttpGet("attendancePerformances")]
        public async Task<IActionResult> GetPerformanceAttendance()
        {
            IEnumerable<PerformanceAttendanceDTO> res =
                await _theaterPerformanceService.GetPerformanceAttendances();
            return Ok(res);
        }

        [HttpGet("mostPopularPerformances")]
        public async Task<IActionResult> GetMostPopularPerformances()
        {
            IEnumerable<PerformanceAttendanceDTO> res =
                await _theaterPerformanceService.GetMostPopularPerformances();
            return Ok(res);
        }

        [HttpGet("mostUnpopularPerformances")]
        public async Task<IActionResult> GetMostUnpopularPerformances()
        {
            IEnumerable<PerformanceAttendanceDTO> res =
                await _theaterPerformanceService.GetMostUnpopularPerformances();
            return Ok(res);
        }

        [HttpGet("popularGenres")]
        public async Task<IActionResult> GetPopularGenres()
        {
            IEnumerable<PopularGenresDTO> res =
                await _theaterPerformanceService.GetPopularGenres();
            return Ok(res);
        }

        [HttpGet("popularComposers")]
        public async Task<IActionResult> GetPopularComposers()
        {
            IEnumerable<PopularComposersDTO> res =
                await _theaterPerformanceService.GetPopularComposers();
            return Ok(res);
        }

        [HttpGet("popularAuthors")]
        public async Task<IActionResult> GetPopularAuthors()
        {
            IEnumerable<PopularAuthorsDTO> res =
                await _theaterPerformanceService.GetPopularAuthors();
            return Ok(res);
        }

        [HttpGet("ticketSales")]
        public async Task<IActionResult> GetTisketSales
            ([FromQuery] SearchTheaterPerformanceDTO parameters)
        {
            IEnumerable<TicketSalesDTO> res =
                await _theaterPerformanceService.GetPeriodTicketSales(parameters);
            return Ok(res);
        }


        [HttpGet("activeTheaterPerformances")]
        public async Task<IActionResult> GetActiveTheaterPerformances()
        {
            IEnumerable<TheaterPerformanceDTO> active =
                await _theaterPerformanceService.GetActiveTheaterPerformances();
            return Ok(active);
        }

        [HttpGet("canceledTheaterPerformances")]
        public async Task<IActionResult> GetCanceledTheaterPerformances()
        {
            IEnumerable<TheaterPerformanceDTO> canceled =
                await _theaterPerformanceService.GetCanceledTheaterPerformances();
            return Ok(canceled);
        }

        [HttpGet("postponedTheaterPerformances")]
        public async Task<IActionResult> GetPostponedTheaterPerformances()
        {
            IEnumerable<TheaterPerformanceDTO> postponed =
                await _theaterPerformanceService.GetPostponedTheaterPerformances();
            return Ok(postponed);
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

        [HttpGet("performanceByTheater/{id}")]
        public async Task<IActionResult> GetPerformancesByTheaterId(int id)
        {
            IEnumerable<TheaterPerformanceDTO> tp =
                await _theaterPerformanceService.GetPerformancesByTheaterId(id);
            return Ok(tp);
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
