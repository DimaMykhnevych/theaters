using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.VariantService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantController : ControllerBase
    {
        private readonly IVariantService _variantService;
        public VariantController(IVariantService variantService)
        {
            _variantService = variantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetVariants()
        {
            IEnumerable<VariantDTO> variants = await _variantService.GetVariants();
            return Ok(variants);
        }


        [HttpPost]
        public async Task<IActionResult> AddVariant([FromBody] VariantDTO variantDTO)
        {
            VariantDTO added = await _variantService.AddVariant(variantDTO);
            if (added == null)
                return BadRequest();
            return Ok(added);
        }


        [HttpDelete("{id}")]
        public async  Task<IActionResult> DeleteVariant(int id)
        {
            bool deleted = await _variantService.DeleteVariant(id);
            return Ok(deleted);
        }

    }
}
