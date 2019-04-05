using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Pedido
{
    public abstract class Pedido
    {
        public int NumeroPedido { get; set; }

        public double Valor()
        {
            return 0;
        }
    }
}
