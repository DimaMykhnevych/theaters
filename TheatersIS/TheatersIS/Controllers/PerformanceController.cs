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

    }
}
