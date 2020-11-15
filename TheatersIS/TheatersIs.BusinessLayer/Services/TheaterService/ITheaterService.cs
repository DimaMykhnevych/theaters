using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.TheaterService
{
    public interface ITheaterService
    {
        TheaterDTO GetTheater(int id);
        IEnumerable<TheaterDTO> GetTheaters();
        TheaterDTO AddTheater(TheaterDTO theater);
        bool DeleteTheater(int id);
        Task<TheaterDTO> UpdateTheater(int id, TheaterDTO theaterDTO);
        Task<IEnumerable<TheaterDTO>> SearchTheaters(SearchTheraterDTO parameters);
    }
}
