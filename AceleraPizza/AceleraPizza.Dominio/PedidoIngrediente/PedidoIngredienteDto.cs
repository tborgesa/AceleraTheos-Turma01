using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngredienteDto
    {
        public Guid Id { get; set; }
        public Guid IdPedido { get; set; }
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }
    }

    public class PedidoIngredienteDtoReturn
    {
        public PedidoIngredienteDtoReturn(PedidoIngredienteDto pedidoIngrediente)
        {
            PedidoIngrediente = pedidoIngrediente;
            Erros = new List<string>();
        }

        public PedidoIngredienteDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public PedidoIngredienteDto PedidoIngrediente { get; }
        public List<string> Erros { get; }
    }
}

