using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.PerformanceService
{
    public interface IPerformanceService
    {
        Task<PerformanceDTO> GetPerformance(int id);
        Task<IEnumerable<PerformanceDTO>> GetPerformances();
        Task<IEnumerable<PerformanceDTO>> SearchPerformances(SearchPerformanceDTO parameters);
        Task<PerformanceDTO> AddPerformance(PerformanceDTO performance);
        Task<PerformanceDTO> UpdatePerformance(int id, PerformanceDTO performanceDTO);
        Task<bool> DeletePerformance(int id);
    }
}
