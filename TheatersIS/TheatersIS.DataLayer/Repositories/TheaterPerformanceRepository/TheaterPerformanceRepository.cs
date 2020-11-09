using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN
{
    public class TheaterPerformanceRepository : Repository<TheaterPerformance>,
        ITheaterPerformanceRepository
    {
        public TheaterPerformanceRepository(TheaterDbContext context) : base(context) { }
    }
}
