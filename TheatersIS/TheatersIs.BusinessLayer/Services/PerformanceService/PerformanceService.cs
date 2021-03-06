﻿using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Builders.PerformanceN;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.PerformanceRepositoryN;

namespace TheatersIs.BusinessLayer.Services.PerformanceService
{
    public class PerformanceService : IPerformanceService
    {
        private readonly IMapper _mapper;
        private readonly IPerformanceRepository _performanceRepository;
        private readonly IPerformanceSearchQueryBuilder _query;
        public PerformanceService(IPerformanceRepository performanceRepository, IMapper mapper,
            IPerformanceSearchQueryBuilder query)
        {
            _mapper = mapper;
            _performanceRepository = performanceRepository;
            _query = query;
        }



        public async Task<PerformanceDTO> GetPerformance(int id)
        {
            Performance performance = _performanceRepository.Get(id);
            return _mapper.Map<PerformanceDTO>(performance);
        }

        public async Task<IEnumerable<PerformanceDTO>> GetPerformances()
        {
            IEnumerable<Performance> performances = _performanceRepository.GetAll();
            return _mapper.Map<IEnumerable<PerformanceDTO>>(performances);
        }



        public async Task<IEnumerable<PerformanceDTO>> SearchPerformances(SearchPerformanceDTO parameters)
        {
            List<Performance> performances = _query.SetBasePerformanceInfo()
                .SetPerformanceName(parameters.Name)
                .SetComposer(parameters.Composer)
                .SetAuthor(parameters.Author)
                .SetGengre(parameters.Genre)
                .SetStatus(parameters.Status)
                .Sort(parameters.FieldToSort, parameters.Descending)
                .Build()
                .ToList();

            return _mapper.Map<IEnumerable<PerformanceDTO>>(performances);
        }

        public async Task<PerformanceDTO> AddPerformance(PerformanceDTO performanceDTO)
        {
            Performance performance = _mapper.Map<Performance>(performanceDTO);

            _performanceRepository.Insert(performance);
            _performanceRepository.Save();


            return _mapper.Map<PerformanceDTO>(performance);
        }

        public async Task<PerformanceDTO> UpdatePerformance(int id, PerformanceDTO performanceDTO)
        {
            Performance performance = _mapper.Map<Performance>(performanceDTO);
            performance.Id = id;
            await _performanceRepository.UpdateAsync(performance);
            return _mapper.Map<PerformanceDTO>(performance);
        }

        public async Task<bool> DeletePerformance(int id)
        {
            Performance performanceToDelete = _performanceRepository.Get(id);
            if (performanceToDelete == null)
                return false;
            _performanceRepository.Delete(performanceToDelete);
            _performanceRepository.Save();
            return true;
        }


    }
}
