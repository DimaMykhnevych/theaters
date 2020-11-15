using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.TheaterPerformanceService
{
    public interface ITheaterPerformanceService
    {
        Task<IEnumerable<TheaterPerformanceDTO>> GetTheaterPerformances();
        Task<TheaterPerformanceDTO> GetTheaterPerformance(int id);

        Task<IEnumerable<TheaterPerformanceDTO>> SearchTheaterPerformances
            (SearchTheaterPerformanceDTO parameters);

        Task<AddAndUpdateTheaterPerformanceDTO> AddTheaterPerformance(AddAndUpdateTheaterPerformanceDTO theaterPerformance);

        Task<AddAndUpdateTheaterPerformanceDTO> UpdateTheaterPerformance
            (int id, AddAndUpdateTheaterPerformanceDTO theaterPerformance);

        Task<bool> DeleteTheaterPerformance(int id);
    }
}
