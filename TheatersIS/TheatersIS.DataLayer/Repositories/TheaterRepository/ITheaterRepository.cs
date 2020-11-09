using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.TheaterRepositoryN
{
    public interface ITheaterRepository : IRepository<Theater>
    {
        IEnumerable<Theater> GetTheatersWithCurrentPerformance();

        IEnumerable<Theater> GetTheatersWithAddress();

        Theater GetTheaterWithAddress(int id);
        Task<Theater> UpdateAsync(Theater theater);
    }
}
