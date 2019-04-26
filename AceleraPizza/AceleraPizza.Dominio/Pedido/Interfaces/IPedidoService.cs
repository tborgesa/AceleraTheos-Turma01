using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido.Interfaces
{
    public interface IPedidoService
    {
        PedidoDtoReturn Inserir(PedidoInserirViewModel pedidoViewModel);
        PedidoDto BuscarPorId(Guid id);
        List<PedidoSearch> BuscarTodos();
        PedidoDtoReturn Atualizar(PedidoAtualizarViewModel pedidoAtualizarViewModel);
        void Excluir(Guid id);
    }
}
