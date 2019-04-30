using Dapper.FluentMap.Dommel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.Pizzaria.Dominio.Cliente;

namespace Theos.Pizzaria.Repository.Map
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        public ClienteMap()
        {
            ToTable("CLIENTE");
            Map(col => col.Id).ToColumn("ID").IsKey();
        }
    }
}
