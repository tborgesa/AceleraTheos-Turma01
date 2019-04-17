using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoInserirViewModel
    {
        public int Tamanho { get; set; } = 1;
        public int IdPedidoIngredientes { get; set; } = 1;
        public int Borda { get; set; } = 1;
        public int Cliente { get; set; } = 1;
        public double Total { get; set; } = 0;
    }
}
