using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.Repositories.AddressRepositoryN;
using TheatersIS.DataLayer.Repositories.OrderRepositoryN;
using TheatersIS.DataLayer.Repositories.PerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.QuestionRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterRepositoryN;
using TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN;
using TheatersIS.DataLayer.Repositories.UserRepositoryN;
using TheatersIS.DataLayer.Repositories.VariantRepositoryN;

namespace TheatersIS.DataLayer.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        IOrderRepository Orders { get; }
        IPerformanceRepository Performances { get; }
        IQuestionRepository Questions { get; }
        ITheaterPerformanceRepository TheaterPerformances { get; }
        ITheaterRepository Theaters { get; }
        IUserAnswerRepository UserAnswers { get; }
        IUserRepository Users { get; }
        IVariantRepository Variants { get; }

        int Complete();

    }
}
