using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.VariantRepositoryN
{
    public class VariantRepository : Repository<Variant>, IVariantRepository
    {
        public VariantRepository(TheaterDbContext context) : base(context) { }
    }
}
