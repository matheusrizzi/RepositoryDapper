using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace ConexaoDapper.Mappings.Base
{
    public static class RegistrationMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new CategoryMap());
                config.ForDommel();
            });
        }
    }
}
