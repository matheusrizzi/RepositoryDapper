using ConexaoDapper.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConexaoDapper.Factories
{
    public class PostgresConnection : IConnectionFactory
    {
        public void BeginTrans()
        {
            throw new NotImplementedException();
        }

        public void CommitTrans()
        {
            throw new NotImplementedException();
        }

        public bool Delete<T>(T entitie) where T : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Insert<T>(T entitie) where T : class
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void RollbackTrans()
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T entitie) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
