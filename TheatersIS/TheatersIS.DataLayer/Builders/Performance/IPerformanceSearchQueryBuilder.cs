using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Builders.PerformanceN
{
    public interface IPerformanceSearchQueryBuilder : IQueryBuilder<Performance>
    {
        IPerformanceSearchQueryBuilder SetBasePerformanceInfo();
        IPerformanceSearchQueryBuilder SetPerformanceName(string name);
        IPerformanceSearchQueryBuilder SetAuthor(string author);
        IPerformanceSearchQueryBuilder SetComposer(string composer);
        IPerformanceSearchQueryBuilder SetGengre(PerformanceGenre? genre);
        IPerformanceSearchQueryBuilder SetStatus(PerformanceStatus? status);
        IPerformanceSearchQueryBuilder Sort(string fieldToSort, bool descending);
    }
}
