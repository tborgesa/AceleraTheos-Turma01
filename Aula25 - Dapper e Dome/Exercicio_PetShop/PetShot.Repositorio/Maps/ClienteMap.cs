using PetShop.Dominio.Pessoas;
using Dapper.FluentMap.Dommel.Mapping;

namespace PetShop.Repositorio.Maps
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(col => col.Id).ToColumn("IdCliente").IsKey();
        }
    }
}
