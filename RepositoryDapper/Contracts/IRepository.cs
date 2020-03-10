using ExpressionBuilder.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDapper.Contracts
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Get(Expression<Func<T, bool>> condition);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> condition);
        void Insert(T entitie);
        bool Update(T entitie);
        bool Delete(T entitie);
    }
}
