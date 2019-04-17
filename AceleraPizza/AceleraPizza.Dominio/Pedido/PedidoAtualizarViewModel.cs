using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Tamanho { get; set; }
        public int IdPedidoIngredientes { get; set; }
        public int Borda { get; set; }
        public double Total { get; set; }
    }
}
