using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngrediente : Entidade
    {
        public PedidoIngrediente() { }
                
        public PedidoIngrediente(Guid idIngrediente, Int16 quantidade)
        {
            IdIngrediente = idIngrediente;
            Quantidade = quantidade;
        }

        public override Guid Id { get; set; }
        public Guid IdPedido { get; set; }
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }
    }
}
