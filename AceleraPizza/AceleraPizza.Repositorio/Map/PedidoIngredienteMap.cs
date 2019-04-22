using Dapper.FluentMap.Dommel.Mapping;
using AceleraPizza.Dominio.PedidoIngrediente;

namespace AceleraPizza.Repositorio.Map
{
    public class PedidoIngredienteMap : DommelEntityMap<_PedidoIngrediente>
    {
        //Mapeamento das propriedades da classe
        public PedidoIngredienteMap()
        {
            ToTable("PEDIDOINGREDIENTE");
            Map(col => col.Id).ToColumn("IdPedidoIngrediente").IsKey();
            //IsKey da informação que esta é a PK
        }
    }
}