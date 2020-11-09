using System;
using System.Collections.Generic;
using System.Text;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.AddressService
{
    public interface IAddressService
    {
        AddressDTO GetAddress(int id);
        IEnumerable<AddressDTO> GetAddresses();
        AddressDTO AddAddress(AddressDTO addressDTO);
        bool DeleteAddress(int id);
        AddressDTO UpdateAddress(int id, AddressDTO addressDTO);
    }
}
