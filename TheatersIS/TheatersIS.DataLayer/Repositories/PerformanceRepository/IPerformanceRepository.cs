using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.PerformanceRepositoryN
{
    public interface IPerformanceRepository : IRepository<Performance>
    {
        Performance GetPerformanceWithTheater(int id);
        IEnumerable<Performance> GetPerformancesWithTheaters();
    }
}
