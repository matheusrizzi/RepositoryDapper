using ConexaoDapper.Contracts;
using ConexaoDapper.Enums;
using ConexaoDapper.Factories;

namespace ConexaoDapper.Builders
{
    public class ConnectionBuilder
    {
        private string _strConn;
        private EDatabase _enuDatabase;

        public ConnectionBuilder WithConnectionString(string strConn)
        {
            _strConn = strConn;
            return this;
        }

        public ConnectionBuilder WithDatabase(EDatabase enuDatabase)
        {
            _enuDatabase = enuDatabase;
            return this;
        }

        public IConnectionFactory Build()
        {
            var factory = new ConnectionFactory();
            return factory.GetConnectionDatabase(_enuDatabase, _strConn);
        }
    }
}
