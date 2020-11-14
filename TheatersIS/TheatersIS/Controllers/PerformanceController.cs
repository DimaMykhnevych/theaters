using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.PerformanceService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        private readonly IPerformanceService _performanceService;
        public PerformanceController(IPerformanceService performanceService)
        {
            _performanceService = performanceService;
        }

        [HttpGet]

        public async Task<IActionResult> GetPerformances([FromQuery] SearchPerformanceDTO parameters)
        {
            IEnumerable<PerformanceDTO> performances = 
                await _performanceService.SearchPerformances(parameters);
            return Ok(performances);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerformance(int id)
        {
            PerformanceDTO performance = await _performanceService.GetPerformance(id);
            if (performance == null)
                return NotFound();
            return Ok(performance);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerformance([FromBody] PerformanceDTO performanceDTO)
        {
            var added = await _performanceService.AddPerformance(performanceDTO);
            if (added == null)
                return BadRequest();
            return Ok(added);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerformance(int id)
        {
            bool deleted = await _performanceService.DeletePerformance(id);
            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerformance(int id, PerformanceDTO performanceDTO)
        {
            var updatedPerformance = await _performanceService.UpdatePerformance(id, performanceDTO);
            if (updatedPerformance == null)
                return NotFound();
            return Ok(updatedPerformance);
        }

    }
}
