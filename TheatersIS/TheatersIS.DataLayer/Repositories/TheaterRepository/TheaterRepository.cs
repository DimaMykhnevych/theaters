using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.TheaterRepositoryN
{
    public class TheaterRepository : Repository<Theater>, ITheaterRepository
    {
        public TheaterRepository(TheaterDbContext context) : base(context) { }

        public IEnumerable<Theater> GetTheatersWithCurrentPerformance()
        {
            return Context.Theaters
                .Include(tp => tp.TheaterPerformances)
                .ThenInclude(p => p.Performance).ToList();
        }

        public IEnumerable<Theater> GetTheatersWithAddress()
        {
            return Context.Theaters
                .Include(t => t.Address).ToList();
        }

        public Theater GetTheaterWithAddress(int id)
        {
            return Context.Theaters
                .Include(t => t.Address).ToList()
                .Find(t => t.Id == id);
        }

        public async Task<Theater> UpdateAsync(Theater theater)
        {


                Context.Update(theater);
                await Context.SaveChangesAsync();

                return theater;
            

        }
    }
}
