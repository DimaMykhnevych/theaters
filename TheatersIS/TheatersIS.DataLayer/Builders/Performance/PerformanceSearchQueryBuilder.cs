using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.PerformanceN
{
    public class PerformanceSearchQueryBuilder : IPerformanceSearchQueryBuilder
    {
        private readonly TheaterDbContext _context;
        private IQueryable<Performance> _query;

        public PerformanceSearchQueryBuilder(TheaterDbContext context) => _context = context;

        public IQueryable<Performance> Build()
        {
            IQueryable<Performance> result = _query;
            _query = null;
            return result;
        }

        public IPerformanceSearchQueryBuilder SetBasePerformanceInfo()
        {
            _query = _context.Performances;
            return this;
        }

        public IPerformanceSearchQueryBuilder SetPerformanceName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {

                _query = _query.Where(t =>
                t.Name != null && t.Name.ToLower().Contains(name.ToLower()));
            }

            return this;
        }

        public IPerformanceSearchQueryBuilder SetAuthor(string author)
        {
            if (!string.IsNullOrEmpty(author))
            {

                _query = _query.Where(t =>
                t.Author != null && t.Author.ToLower().Contains(author.ToLower()));
            }

            return this;
        }


        public IPerformanceSearchQueryBuilder SetComposer(string composer)
        {
            if (!string.IsNullOrEmpty(composer))
            {

                _query = _query.Where(t =>
                t.Composer != null && t.Composer.ToLower().Contains(composer.ToLower()));
            }

            return this;
        }

        public IPerformanceSearchQueryBuilder SetGengre(PerformanceGenre? genre)
        {
            if (genre.HasValue)
            {

                _query = _query.Where(t => t.PerformanceGenre == genre.Value);
            }

            return this;
        }


        public IPerformanceSearchQueryBuilder SetStatus(PerformanceStatus? status)
        {
            if (status.HasValue)
            {

                _query = _query.Where(t => t.PerformanceStatus == status.Value);
            }

            return this;
        }

        public IPerformanceSearchQueryBuilder Sort(string fieldToSort, bool descending)
        {
            if (!string.IsNullOrEmpty(fieldToSort))
            {
                switch (fieldToSort.ToLower())
                {
                    case "name":
                        _query = descending ? _query.OrderByDescending(t => t.Name)
                            : _query.OrderBy(t => t.Name);
                        break;
                    default: break;
                }
            }

            return this;
        }
    }
}
