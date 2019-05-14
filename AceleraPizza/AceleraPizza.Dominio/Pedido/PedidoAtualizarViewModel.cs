using AceleraPizza.Dominio.Borda.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngredienteViewModel;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public ETamanho Tamanho { get; set; }
        //todo Não utilizar Model em classes de ViewModel e Dto - OK
        public List<PedidoIngredienteAlias> ListaIngredientes { get; set; }
        public EBorda Borda { get; set; }
    }
}
