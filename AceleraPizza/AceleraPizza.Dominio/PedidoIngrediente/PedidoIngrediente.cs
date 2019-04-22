using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class _PedidoIngrediente : Entidade
    {
        public _PedidoIngrediente() { }
                
        public _PedidoIngrediente(Guid idPedido, Guid idIngrediente, Int16 quantidade)
        {
            IdIngrediente = idIngrediente;
            Quantidade = quantidade;
        }
        
        public override Guid Id { get; set; }
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }
    }
}
