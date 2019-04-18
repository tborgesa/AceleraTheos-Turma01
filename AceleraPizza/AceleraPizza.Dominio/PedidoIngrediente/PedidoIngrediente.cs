using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngrediente : Entidade
    {
        public PedidoIngrediente() { }

        public PedidoIngrediente(Guid idPedido, Guid idIngrediente)
        {
            IdPedido = idPedido;
            IdIngrediente = idIngrediente;
        }

        //TODO: O total seria um valor zerado para depois ser preenchido?
        public override Guid Id { get; set; }

        public Guid IdPedido { get; set; }
        public Guid IdIngrediente { get; set; }
    }
}
