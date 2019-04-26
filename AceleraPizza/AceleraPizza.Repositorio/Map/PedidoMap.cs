using Dapper.FluentMap.Dommel.Mapping;
using AceleraPizza.Dominio.Pedido;

namespace AceleraPizza.Repositorio.Map
{
    public class PedidoMap : DommelEntityMap<Pedido>
    {
        //Mapeamento das propriedades da classe
        public PedidoMap()
        {
            ToTable("PEDIDO");
            Map(col => col.Id).ToColumn("IdPedido").IsKey();
        }
    }
}