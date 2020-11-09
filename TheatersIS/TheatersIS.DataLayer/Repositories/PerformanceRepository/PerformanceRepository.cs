using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.PerformanceRepositoryN
{
    public class PerformanceRepository : Repository<Performance>, IPerformanceRepository
    {
        public PerformanceRepository(TheaterDbContext context) : base(context) { }
    }
}
