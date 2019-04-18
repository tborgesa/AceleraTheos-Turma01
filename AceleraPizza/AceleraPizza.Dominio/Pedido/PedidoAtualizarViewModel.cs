using System;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Tamanho { get; set; }
        public int IdPedidoIngrediente { get; set; }
        public int Borda { get; set; }
        public double Total { get; set; }
    }
}
