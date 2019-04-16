using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoDto
    {
        public Guid Id { get; set; }
        public int Tamanho { get; set; }
        public int IdListaIngredientes { get; set; }
        public int Borda { get; set; }
        public int Cliente { get; set; }
        public double Total { get; set; }
    }

    public class PedidoDtoReturn
    {
        public PedidoDtoReturn(PedidoDto pedido)
        {
            Pedido = pedido;
            Erros = new List<string>();
        }

        public PedidoDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public PedidoDto Pedido { get; }
        public List<string> Erros { get; }
    }
}

