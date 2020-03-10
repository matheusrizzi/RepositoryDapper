using Dapper.FluentMap.Dommel.Mapping;
using RepositoryDapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDapper.Mappings
{
    public class CategoryMap:DommelEntityMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            Map(x => x.Id).ToColumn("Id").IsKey();
            Map(x => x.Name).ToColumn("Name");
        }
    }
}
