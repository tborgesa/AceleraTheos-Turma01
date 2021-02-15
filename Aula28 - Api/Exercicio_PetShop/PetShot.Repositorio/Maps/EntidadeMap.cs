using Dapper.FluentMap.Dommel.Mapping;
using PetShop.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Repositorio.Maps
{
    class EntidadeMap : DommelEntityMap<Entidade>
    {
        public EntidadeMap()
        {
            Map(col => col.Id).IsKey();
        }
    }
}
