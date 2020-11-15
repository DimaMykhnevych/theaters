using System.Linq;

namespace TheatersIS.DataLayer.Builders
{
    public interface IQueryBuilder<TEntity>
    {
        IQueryable<TEntity> Build();
    }
}
