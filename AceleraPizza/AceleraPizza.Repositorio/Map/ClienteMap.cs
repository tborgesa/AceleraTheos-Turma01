using Dapper.FluentMap.Dommel.Mapping;
using AceleraPizza.Dominio.Cliente;

namespace AceleraPizza.Repositorio.Map
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        //Mapeamento das propriedades da classe
        public ClienteMap()
        {
            ToTable("CLIENTE");
            Map(col => col.Id).ToColumn("IdCliente").IsKey();
            //IsKey da informação que esta é a PK
            //Map(col => col.DataInsercao).ToColumn("DataInsercao");
        }
    }
}