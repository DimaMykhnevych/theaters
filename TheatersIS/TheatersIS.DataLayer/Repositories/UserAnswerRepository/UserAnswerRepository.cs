using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN
{
    public class UserAnswerRepository : Repository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(TheaterDbContext context) : base(context) { }

        public async Task<IEnumerable<UserAnswer>> GetUserAnswersWithVariants()
        {
            return Context.UserAnswers.Include(u => u.Variant).ToList();
        }
    }
}
