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
        //todo Não utilizar Model em classes de ViewModel e Dto
        public List<PedidoIngrediente.PedidoIngrediente> ListaIngredientes { get; set; }
        public EBorda Borda { get; set; }
    }
}
