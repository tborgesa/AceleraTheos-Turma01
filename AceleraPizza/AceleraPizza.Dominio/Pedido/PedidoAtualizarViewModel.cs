using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public ETamanho Tamanho { get; set; }
        public List<PedidoIngrediente.PedidoIngrediente> ListaIngredientes { get; set; }
        public Guid IdPedidoIngrediente { get; set; }
        public EBorda Borda { get; set; }
    }
}
