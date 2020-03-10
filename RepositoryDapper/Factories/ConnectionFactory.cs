using ConexaoDapper.Contracts;
using ConexaoDapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDapper.Factories
{
    public class ConnectionFactory
    {
        public IConnectionFactory GetConnectionDatabase(EDatabase enuDatabase, string strConn)
        {
            switch (enuDatabase)
            {
                case EDatabase.Postgres:
                    return null;
                case EDatabase.SqlServer:
                    return new SqlServerConnection(strConn);
                default:
                    return null;
            }
        }
    }
}
