using PetShop.Dominio.Animais;
using Dapper.FluentMap.Dommel.Mapping;

namespace PetShop.Repositorio.Maps
{
    public class CachorroMap : DommelEntityMap<Cachorro>
    {
        public CachorroMap()
        {
            ToTable("Cachorro");
            Map(col => col.Id).ToColumn("IdCachorro").IsKey();
            Map(col => col.ClienteId).ToColumn("ClienteId");
            Map(col => col.Especie).ToColumn("IdEspecie");
            Map(col => col.Nome).ToColumn("NomeCachorro");
            Map(col => col.Cliente).Ignore();
        }
    }
}
