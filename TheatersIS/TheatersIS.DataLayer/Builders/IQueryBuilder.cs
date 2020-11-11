using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatersIS.DataLayer.Builders
{
    public interface IQueryBuilder<TEntity>
    {
        IQueryable<TEntity> Build();
    }
}
