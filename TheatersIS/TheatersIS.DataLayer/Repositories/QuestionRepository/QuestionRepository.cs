using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.QuestionRepositoryN
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(TheaterDbContext context) : base(context) { }
    }
}
