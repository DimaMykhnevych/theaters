using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TheaterDbContext _context;

        public UnitOfWork(TheaterDbContext context)
        {
            _context = context;
            Addresses = new AddressRepository(_context);
            Orders = new OrderRepository(_context);
            Performances = new PerformanceRepository(_context);
            Questions = new QuestionRepository(_context);
            TheaterPerformances = new TheaterPerformanceRepository(_context);
            UserAnswers = new UserAnswerRepository(_context);
            Users = new UserRepository(_context);
            Variants = new VariantRepository(_context);
            Theaters = new TheaterRepository(_context);
        }

        public IAddressRepository Addresses { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IPerformanceRepository Performances { get; private set; }
        public IQuestionRepository Questions { get; private set; }
        public ITheaterPerformanceRepository TheaterPerformances { get; private set; }
        public IUserAnswerRepository UserAnswers { get; private set; }
        public IUserRepository Users { get; private set; }
        public IVariantRepository Variants { get; private set; }
        public ITheaterRepository Theaters { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
