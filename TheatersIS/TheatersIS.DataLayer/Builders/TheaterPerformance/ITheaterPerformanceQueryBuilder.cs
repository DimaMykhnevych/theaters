using System;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.TheaterPerformanceN
{
    public interface ITheaterPerformanceQueryBuilder : IQueryBuilder<TheaterPerformance>
    {
        ITheaterPerformanceQueryBuilder SetBaseTheaterPerformanceInfo();
        ITheaterPerformanceQueryBuilder SetBaseTheaterPerformanceWithOrders();
        ITheaterPerformanceQueryBuilder SetTheaterName(string name);
        ITheaterPerformanceQueryBuilder SetPerformanceName(string name);
        ITheaterPerformanceQueryBuilder SetTheaterPerformanceDate(DateTime? startDate, DateTime? endDate);
        ITheaterPerformanceQueryBuilder SetTheaterPerformancePrice(int? startPrice, int? endPrice);
        ITheaterPerformanceQueryBuilder Sort(string fieldToSort, bool descending);
    }
}
