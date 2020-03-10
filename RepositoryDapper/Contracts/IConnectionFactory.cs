using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDapper.Contracts
{
    public interface IConnectionFactory:IDisposable
    {
        void Open();
        void BeginTrans();
        void CommitTrans();
        void RollbackTrans();
        T Get<T>(Expression<Func<T, bool>> predicate) where T : class;
        IEnumerable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class;
        IEnumerable<T> GetAll<T>() where T : class;
        void Insert<T>(T entitie) where T : class;
        bool Update<T>(T entitie) where T : class;
        bool Delete<T>(T entitie) where T : class;
    }
}
