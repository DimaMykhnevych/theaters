using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.PerformanceRepositoryN
{
    public interface IPerformanceRepository : IRepository<Performance>
    {
        Performance GetPerformanceWithTheater(int id);
        IEnumerable<Performance> GetPerformancesWithTheaters();

        Task<Performance> UpdateAsync(Performance performance);
    }
}
