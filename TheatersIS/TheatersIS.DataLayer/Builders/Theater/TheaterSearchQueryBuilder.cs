using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.TheaterN
{
    public class TheaterSearchQueryBuilder : ITheaterSearchQueryBuilder
    {
        private readonly TheaterDbContext _context;
        private IQueryable<Theater> _query;

        public TheaterSearchQueryBuilder(TheaterDbContext context) => _context = context;

        public IQueryable<Theater> Build()
        {
            IQueryable<Theater> result = _query;
            _query = null;
            return result;
        }

        public ITheaterSearchQueryBuilder SetBaseTheatersInfo()
        {
            _query = _context.Theaters.Include(t => t.Address);
            return this;
        }

        public ITheaterSearchQueryBuilder SetTheaterName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {

                _query = _query.Where(t =>
                t.Name != null && t.Name.ToLower().Contains(name.ToLower()));
            }

            return this;
        }

        public ITheaterSearchQueryBuilder SetTheaterType(TheaterTypes? type)
        {
            if (type.HasValue)
            {

                _query = _query.Where(t => t.TheaterType == type.Value);
            }

            return this;
        }

        public ITheaterSearchQueryBuilder Sort(string fieldToSort, bool descending)
        {
            if (!string.IsNullOrEmpty(fieldToSort))
            {
                switch (fieldToSort.ToLower())
                {
                    case "name":
                        _query = descending ? _query.OrderByDescending(t => t.Name)
                            : _query.OrderBy(t => t.Name);
                        break;
                    case "type":
                        _query = descending ? _query.OrderByDescending(t => t.TheaterType)
                            : _query.OrderBy(t => t.TheaterType);
                        break;
                    default: break;
                }
            }

            return this;
        }
    }
}
