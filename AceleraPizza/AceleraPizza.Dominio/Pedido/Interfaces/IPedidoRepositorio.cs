using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido.Interfaces
{
    public interface IPedidoRepositorio
    {
        void Inserir(Pedido pedido);
        void Atualizar(Pedido pedido);
        void Excluir(Guid id);
        Pedido BuscarPorId(Guid id);
        List<Pedido> BuscarTodos();
        bool BuscarPorCliente(Guid id);
    }
}