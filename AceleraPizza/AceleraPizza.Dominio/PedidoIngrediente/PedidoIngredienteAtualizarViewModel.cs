using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngredienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid IdPedido { get; set; }
        public Guid IdIngrediente { get; set; }
    }
}
