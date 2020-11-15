using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN
{
    public class UserAnswerRepository : Repository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(TheaterDbContext context) : base(context) { }
    }
}
