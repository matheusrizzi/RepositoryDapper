using ConexaoDapper.Contracts;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace ConexaoDapper.Factories
{
    public class SqlServerConnection : IConnectionFactory
    {
        SqlConnection _conn;
        SqlTransaction _transaction;

        public SqlServerConnection(string strConn) => _conn = new SqlConnection(strConn);
        public void Open() => _conn.Open();
        public void BeginTrans() => _transaction = _conn.BeginTransaction();
        public void CommitTrans() => _transaction.Commit();
        public void RollbackTrans() => _transaction.Rollback();
        public T Get<T>(Expression<Func<T, bool>> predicate) where T : class => GetAll<T>(predicate)?.FirstOrDefault();
        public IEnumerable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class => _conn.Select<T>(predicate);
        public IEnumerable<T> GetAll<T>() where T : class => _conn.GetAll<T>();
        public void Insert<T>(T entitie) where T:class => _conn.Insert<T>(entitie, _transaction);
        public bool Update<T>(T entitie) where T : class => _conn.Update<T>(entitie, _transaction);
        public bool Delete<T>(T entitie) where T : class => _conn.Delete<T>(entitie, _transaction);
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
            }

            if(_conn != null)
            {
                _conn.Close();
                _conn.Dispose();
            }
        }
    }
}
