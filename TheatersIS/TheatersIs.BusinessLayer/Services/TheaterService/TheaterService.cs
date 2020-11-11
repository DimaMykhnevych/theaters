using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Builders.TheaterN;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.AddressRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterRepositoryN;

namespace TheatersIs.BusinessLayer.Services.TheaterService
{
    public class TheaterService : ITheaterService
    {
        private readonly ITheaterRepository _theatersRepository;

        private readonly IAddressRepository _addressRepository;
        private readonly ITheaterSearchQueryBuilder _query;

        private readonly IMapper _mapper;


        public TheaterService(ITheaterRepository theatersRepository,
            IMapper mapper, IAddressRepository addressRepository,
            ITheaterSearchQueryBuilder queryBuilder)
        {
            _theatersRepository = theatersRepository;
            _mapper = mapper;
            _addressRepository = addressRepository;
            _query = queryBuilder;
        }
        public IEnumerable<TheaterDTO> GetTheaters()
        {
            var theaters = _theatersRepository.GetTheatersWithAddress();
            return _mapper.Map<IEnumerable<TheaterDTO>>(theaters).ToList();

        }

        public TheaterDTO GetTheater(int id)
        {
            var theater = _theatersRepository.GetTheaterWithAddress(id);
            return _mapper.Map<TheaterDTO>(theater);
        }

        public TheaterDTO AddTheater(TheaterDTO theaterDTO)
        {
            var theater = _mapper.Map<Theater>(theaterDTO);

            _theatersRepository.Insert(theater);
            _theatersRepository.Save();


            return _mapper.Map<TheaterDTO>(theater);

        }

        public bool DeleteTheater(int id)
        {
            var theaterToDelete = _theatersRepository.Get(id);
            if (theaterToDelete == null)
                return false;
            _theatersRepository.Delete(theaterToDelete);
            _theatersRepository.Save();
            return true;
        }

        public async Task<TheaterDTO> UpdateTheater(int id, TheaterDTO theaterDTO)
        {
            var theater = _mapper.Map<Theater>(theaterDTO);
            theater.Id = id;
            await _theatersRepository.UpdateAsync(theater);
            return _mapper.Map<TheaterDTO>(theater);
        }

        public async Task<IEnumerable<TheaterDTO>> SearchTheaters(SearchTheraterDTO parameters)
        {
            List<Theater> theaters = _query.SetBaseTheatersInfo()
                .SetTheaterName(parameters.Name)
                .SetTheaterType(parameters.Type)
                .Sort(parameters.FieldToSort, parameters.Descending)
                .Build()
                .ToList();

            return _mapper.Map<IEnumerable<TheaterDTO>>(theaters);
        }
    }
}
