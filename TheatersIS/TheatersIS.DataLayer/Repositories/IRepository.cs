using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TheatersIS.DataLayer.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        void Save();


    }
}
