using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngredienteViewModel;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoViewModel
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public ETamanho Tamanho { get; set; }
        public EBorda Borda { get; set; }
        public double Total { get; set; }
        public List<PedidoIngredienteAlias> ListaIngredientes { get; set; }
        public string NomeCliente { get; set; }
    }
}
