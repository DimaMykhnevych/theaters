using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Builders.TheaterPerformanceN;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN;

namespace TheatersIs.BusinessLayer.Services.TheaterPerformanceService
{
    public class TheaterPerformanceService : ITheaterPerformanceService
    {
        private readonly IMapper _mapper;
        private readonly ITheaterPerformanceRepository _theaterPerformanceRepository;
        private readonly ITheaterPerformanceQueryBuilder _query;

        public TheaterPerformanceService(IMapper mapper,
            ITheaterPerformanceRepository theaterPerformanceRepository,
            ITheaterPerformanceQueryBuilder theaterPerformanceQueryBuilder)
        {
            _mapper = mapper;
            _theaterPerformanceRepository = theaterPerformanceRepository;
            _query = theaterPerformanceQueryBuilder;

        }



        public async Task<TheaterPerformanceDTO> GetTheaterPerformance(int id)
        {
            TheaterPerformance theaterPerformance =
                await _theaterPerformanceRepository.GetTheaterPerformance(id);
            return _mapper.Map<TheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetTheaterPerformances()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
                await _theaterPerformanceRepository.GetTheaterPerformances();
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(theaterPerformances);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> SearchTheaterPerformances
            (SearchTheaterPerformanceDTO parameters)
        {
            List<TheaterPerformance> theaterPerformances =
                 _query.SetBaseTheaterPerformanceInfo()
                 .SetTheaterName(parameters.TheaterName)
                 .SetPerformanceName(parameters.PerformanceName)
                 .SetTheaterPerformanceDate(parameters.StartDate, parameters.EndDate)
                 .SetTheaterPerformancePrice(parameters.StartPrice, parameters.EndPrice)
                 .Sort(parameters.FieldToSort, parameters.Descending)
                 .Build()
                 .ToList();
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(theaterPerformances);

        }

        public async Task<AddAndUpdateTheaterPerformanceDTO> AddTheaterPerformance
            (AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            TheaterPerformance theaterPerformance = _mapper.Map<TheaterPerformance>(theaterPerformanceDTO);

            _theaterPerformanceRepository.Insert(theaterPerformance);
            _theaterPerformanceRepository.Save();


            return _mapper.Map<AddAndUpdateTheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<AddAndUpdateTheaterPerformanceDTO> UpdateTheaterPerformance
            (int id, AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            TheaterPerformance theaterPerformance = _mapper.Map<TheaterPerformance>(theaterPerformanceDTO);
            theaterPerformance.Id = id;
            await _theaterPerformanceRepository.UpdateAsync(theaterPerformance);
            return _mapper.Map<AddAndUpdateTheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<bool> DeleteTheaterPerformance(int id)
        {
            TheaterPerformance tpToDelete = _theaterPerformanceRepository.Get(id);
            if (tpToDelete == null)
                return false;
            _theaterPerformanceRepository.Delete(tpToDelete);
            _theaterPerformanceRepository.Save();
            return true;
        }


    }
}
