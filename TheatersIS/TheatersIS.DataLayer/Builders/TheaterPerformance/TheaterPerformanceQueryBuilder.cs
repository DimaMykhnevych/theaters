using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.TheaterPerformanceN
{
    public class TheaterPerformanceQueryBuilder : ITheaterPerformanceQueryBuilder
    {
        private readonly TheaterDbContext _context;
        private IQueryable<TheaterPerformance> _query;
        public TheaterPerformanceQueryBuilder(TheaterDbContext context) => _context = context;
        public IQueryable<TheaterPerformance> Build()
        {
            IQueryable<TheaterPerformance> result = _query;
            _query = null;
            return result;
        }

        public ITheaterPerformanceQueryBuilder SetBaseTheaterPerformanceInfo()
        {
            _query = _context.TheaterPerformances
                .Include(tp => tp.Theater)
                .Include(tp => tp.Performance);
            return this;
        }

        public ITheaterPerformanceQueryBuilder SetBaseTheaterPerformanceWithOrders()
        {
            _query = _context.TheaterPerformances
                .Include(tp => tp.Theater)
                .Include(tp => tp.Performance)
                .Include(tp => tp.Orders);
            return this;
        }

        public ITheaterPerformanceQueryBuilder SetPerformanceName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {

                _query = _query.Where(t =>
                t.Performance.Name != null &&
                t.Performance.Name.ToLower().Contains(name.ToLower()));
            }

            return this;
        }

        public ITheaterPerformanceQueryBuilder SetTheaterName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {

                _query = _query.Where(t =>
                t.Theater.Name != null &&
                t.Theater.Name.ToLower().Contains(name.ToLower()));
            }

            return this;
        }

        public ITheaterPerformanceQueryBuilder SetTheaterPerformanceDate
            (DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null && endDate != null)
            {
                _query = _query.Where(tp => tp.PerformanceDate <= endDate);
            }
            else if (endDate == null && startDate != null)
            {
                _query = _query.Where(tp => tp.PerformanceDate >= startDate);
            }
            else if (startDate != null && endDate != null)
            {
                _query = _query.Where(tp => tp.PerformanceDate >= startDate
                && tp.PerformanceDate <= endDate);
            }
            return this;
        }

        public ITheaterPerformanceQueryBuilder SetTheaterPerformancePrice(int? startPrice, int? endPrice)
        {
            if (startPrice == null && endPrice != null)
            {
                _query = _query.Where(tp => tp.TicketPrice <= endPrice);
            }
            else if (endPrice == null && startPrice != null)
            {
                _query = _query.Where(tp => tp.TicketPrice >= startPrice);
            }
            else if (endPrice != null && startPrice != null)
            {
                _query = _query.Where(tp => tp.TicketPrice >= startPrice
               && tp.TicketPrice <= endPrice);
            }
            return this;
        }

        public ITheaterPerformanceQueryBuilder Sort(string fieldToSort, bool descending)
        {
            if (!string.IsNullOrEmpty(fieldToSort))
            {
                switch (fieldToSort.ToLower())
                {
                    case "theatername":
                        _query = descending ? _query.OrderByDescending(t => t.Theater.Name)
                            : _query.OrderBy(t => t.Theater.Name);
                        break;
                    case "performancename":
                        _query = descending ? _query.OrderByDescending(t => t.Performance.Name)
                            : _query.OrderBy(t => t.Performance.Name);
                        break;
                    case "ticketprice":
                        _query = descending ? _query.OrderByDescending(t => t.TicketPrice)
                            : _query.OrderBy(t => t.TicketPrice);
                        break;
                    case "date":
                        _query = descending ? _query.OrderByDescending(t => t.PerformanceDate)
                           : _query.OrderBy(t => t.PerformanceDate);
                        break;

                    default: break;
                }
            }

            return this;
        }
    }
}
