using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoSearch
    {
        public Guid Id { get; set; }
        public ETamanho Tamanho{ get; set; }
        public List<_PedidoIngrediente> ListaIngredientes { get; set; }
        public EBorda Borda{ get; set; }
        public Guid IdCliente { get; set; }
        public double Total { get; set; }
    }
}
