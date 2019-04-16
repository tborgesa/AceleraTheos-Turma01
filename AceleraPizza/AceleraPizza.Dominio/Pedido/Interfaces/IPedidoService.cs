using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido.Interfaces
{
    public interface IPedidoService
    {
        PedidoDtoReturn Inserir(PedidoInserirViewModel contratadoViewModel);
        PedidoDto BuscarPorId(Guid id);
        List<PedidoSearch> BuscarTodos();
        PedidoDtoReturn Atualizar(PedidoAtualizarViewModel contratadoAtualizarViewModel);
        void Excluir(Guid id);
    }
}
