using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoSearch
    {
        public Guid Id { get; set; }
        public int Tamanho { get; set; }
        public int IdPedidoIngredientes { get; set; }
        public int Borda { get; set; }
        public int Cliente { get; set; }
        public double Total { get; set; }
    }
}
