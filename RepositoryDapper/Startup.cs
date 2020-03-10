using ConexaoDapper.Mappings.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDapper
{
    public class Startup
    {
        public void Run()
        {
            RegistrationMappings.Register();
        }
    }
}
