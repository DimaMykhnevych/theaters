using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.AddressRepositoryN;

namespace TheatersIs.BusinessLayer.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public IEnumerable<AddressDTO> GetAddresses()
        {
            var addresses = _addressRepository.GetAll();
            return _mapper.Map<IEnumerable<AddressDTO>>(addresses).ToList();
        }
        public AddressDTO GetAddress(int id)
        {
            var address = _addressRepository.Get(id);
            return _mapper.Map<AddressDTO>(address);
        }

        public AddressDTO AddAddress(AddressDTO addressDTO)
        {
            var address = _mapper.Map<Address>(addressDTO);
            _addressRepository.Insert(address);
            _addressRepository.Save();

            return _mapper.Map<AddressDTO>(address);
        }

        public bool DeleteAddress(int id)
        {
            var address = _addressRepository.Get(id);
            if (address == null)
                return false;

            _addressRepository.Delete(address);
            _addressRepository.Save();
            return true;
        }

        public AddressDTO UpdateAddress(int id, AddressDTO addressDTO)
        {
            var address = _mapper.Map<Address>(addressDTO);
            address.Id = id;
             _addressRepository.Update(address);
            _addressRepository.Save();

            return _mapper.Map<AddressDTO>(address);
        }
    }
}
