using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN
{
    public interface ITheaterPerformanceRepository : IRepository<TheaterPerformance>
    {
        Task<IEnumerable<TheaterPerformance>> GetTheaterPerformances();
        Task<TheaterPerformance> GetTheaterPerformance(int id);
        Task<TheaterPerformance> UpdateAsync(TheaterPerformance theaterPerformance);
    }
}
