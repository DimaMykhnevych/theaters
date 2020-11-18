using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN
{
    public class TheaterPerformanceRepository : Repository<TheaterPerformance>,
        ITheaterPerformanceRepository
    {
        public TheaterPerformanceRepository(TheaterDbContext context) : base(context) { }

        public async Task<TheaterPerformance> GetTheaterPerformance(int id)
        {
            return Context.TheaterPerformances
                .Include(tp => tp.Theater)
                .Include(tp => tp.Performance)
                .FirstOrDefault(tp => tp.Id == id);

        }

        public async Task<IEnumerable<TheaterPerformance>> GetTheaterPerformances()
        {
            return Context.TheaterPerformances
                .Include(tp => tp.Theater)
                .Include(tp => tp.Performance)
                .ToList(); //!!!
        }

        public async Task<IEnumerable<TheaterPerformance>> GetTheaterPerformancesWithOrders()
        {
            return Context.TheaterPerformances
                .Include(tp => tp.Theater)
                .Include(tp => tp.Performance)
                .Include(tp => tp.Orders)
                .ToList();
        }

        public async Task<TheaterPerformance> GetTheaterPerformanceWithOrdersAndAddressById(int id)
        {
            return Context.TheaterPerformances
                  .Include(tp => tp.Theater)
                  .Include(tp => tp.Theater.Address)
                  .Include(tp => tp.Performance)
                  .Include(tp => tp.Orders)
                  .FirstOrDefault(tp => tp.Id == id);
        }

        public async Task<TheaterPerformance> UpdateAsync(TheaterPerformance theaterPerformance)
        {

            Context.Update(theaterPerformance);
            await Context.SaveChangesAsync();

            return theaterPerformance;

        }
    }
}
