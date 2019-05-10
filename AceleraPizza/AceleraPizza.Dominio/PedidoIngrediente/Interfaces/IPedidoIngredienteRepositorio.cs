using System;
using System.Collections.Generic;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngredienteView;

namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteRepositorio
    {
        void Inserir(PedidoIngrediente PedidoIngrediente);
        void Excluir(Guid id);
        PedidoIngrediente BuscarPorId(Guid id);
        List<PedidoIngredienteAlias> BuscarTodosIdPedido(Guid id);
    }
}
