using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Services.AddressService;

namespace TheatersIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult GetAddresses()
        {
            var addresses = _addressService.GetAddresses();
            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public IActionResult GetAddress(int id)
        {
            var address = _addressService.GetAddress(id);
            if (address == null)
                return NotFound();
            return Ok(address);
        }

        [HttpPost]
        public IActionResult AddAddress(AddressDTO addressDTO)
        {
            var addedAddress = _addressService.AddAddress(addressDTO);
            if (addedAddress == null)
                return BadRequest();
            return Ok(addedAddress);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            var deleted = _addressService.DeleteAddress(id);
            if (deleted)
                return Ok();
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, AddressDTO addressDTO)
        {
            var updatedAddress = _addressService.UpdateAddress(id, addressDTO);
            if(updatedAddress == null)
                return NotFound();
            return Ok(updatedAddress);
        }
    }
}
