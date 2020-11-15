using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.UserRepositoryN
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TheaterDbContext context) : base(context) { }
    }
}
