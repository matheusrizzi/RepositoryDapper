using ConexaoDapper.Builders;
using ConexaoDapper.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConexaoDapper.Repositories.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IConnectionFactory _connection;

        public Repository()
        {
            _connection = new ConnectionBuilder()
                                .WithConnectionString(@"Server = GOVBR7083\MSSQL2017DEV; Database = TESTE_DAPPER; User Id = PRONIM; Password = PRO2010nim;")
                                .WithDatabase(Enums.EDatabase.SqlServer)
                                .Build();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> condition) => _connection.Get<TEntity>(condition);
        public IEnumerable<TEntity> GetAll() => _connection.GetAll<TEntity>();
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> condition) => _connection.GetAll<TEntity>(condition);
        public void Insert(TEntity entitie) => _connection.Insert<TEntity>(entitie);
        public bool Update(TEntity entitie) => _connection.Update<TEntity>(entitie);
        public bool Delete(TEntity entitie) => _connection.Delete<TEntity>(entitie);
        public void Dispose() => _connection.Dispose();
    }


}
