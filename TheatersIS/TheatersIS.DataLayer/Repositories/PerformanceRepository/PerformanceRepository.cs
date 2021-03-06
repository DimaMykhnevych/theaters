﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.PerformanceRepositoryN
{
    public class PerformanceRepository : Repository<Performance>, IPerformanceRepository
    {
        public PerformanceRepository(TheaterDbContext context) : base(context) { }

        public Performance GetPerformanceWithTheater(int id)
        {
            return Context.Performances.Include(p => p.TheaterPerformances)
                .ThenInclude(tp => tp.Theater)
                .ThenInclude(t => t.Address)
                .ToList()
                .Find(p => p.Id == id);
        }

        public IEnumerable<Performance> GetPerformancesWithTheaters()
        {
            return Context.Performances.Include(p => p.TheaterPerformances)
                .ThenInclude(tp => tp.Theater)
                .ThenInclude(t => t.Address)
                .ToList();
        }

        public async Task<Performance> UpdateAsync(Performance performance)
        {

            Context.Update(performance);
            await Context.SaveChangesAsync();

            return performance;

        }
    }
}
