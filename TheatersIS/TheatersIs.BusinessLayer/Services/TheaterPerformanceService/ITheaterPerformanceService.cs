using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.TheaterPerformanceService
{
    public interface ITheaterPerformanceService
    {
        Task<IEnumerable<TheaterPerformanceDTO>> GetTheaterPerformances();
        Task<TheaterPerformanceDTO> GetTheaterPerformance(int id);

        Task<IEnumerable<TheaterAttendanceDTO>> GetTheaterPerformancesWithOrders();
        Task<IEnumerable<TheaterAttendanceDTO>> GetMostPopularTheaters();
        Task<IEnumerable<TheaterAttendanceDTO>> GetMostUnpopularTheaters();

        Task<IEnumerable<PerformanceAttendanceDTO>> GetPerformanceAttendances();
        Task<IEnumerable<PerformanceAttendanceDTO>> GetMostPopularPerformances();
        Task<IEnumerable<PerformanceAttendanceDTO>> GetMostUnpopularPerformances();

        Task<IEnumerable<TicketSalesDTO>> GetPeriodTicketSales(SearchTheaterPerformanceDTO parameters);

        Task<IEnumerable<PopularGenresDTO>> GetPopularGenres();
        Task<IEnumerable<PopularAuthorsDTO>> GetPopularAuthors();
        Task<IEnumerable<PopularComposersDTO>> GetPopularComposers();

        Task<IEnumerable<TheaterPerformanceDTO>> SearchTheaterPerformances
            (SearchTheaterPerformanceDTO parameters);

        Task<AddAndUpdateTheaterPerformanceDTO> AddTheaterPerformance
            (AddAndUpdateTheaterPerformanceDTO theaterPerformance);

        Task<AddAndUpdateTheaterPerformanceDTO> UpdateTheaterPerformance
            (int id, AddAndUpdateTheaterPerformanceDTO theaterPerformance);

        Task<bool> DeleteTheaterPerformance(int id);
    }
}
