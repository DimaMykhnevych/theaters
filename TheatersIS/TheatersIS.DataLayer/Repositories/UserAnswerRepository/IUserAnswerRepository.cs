using System.Collections.Generic;
using System.Threading.Tasks;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN
{
    public interface IUserAnswerRepository : IRepository<UserAnswer>
    {
        Task<IEnumerable<UserAnswer>> GetUserAnswersWithVariants();
    }
}
