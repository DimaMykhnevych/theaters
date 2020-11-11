using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.TheaterN
{
    public interface ITheaterSearchQueryBuilder : IQueryBuilder<Theater>
    {
        ITheaterSearchQueryBuilder SetBaseTheatersInfo();
        ITheaterSearchQueryBuilder SetTheaterName(string name);
        ITheaterSearchQueryBuilder SetTheaterType(TheaterTypes? type);
        ITheaterSearchQueryBuilder Sort(string fieldToSort, bool descending);

    }
}
