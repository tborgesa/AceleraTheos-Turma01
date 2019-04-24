using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteRepositorio
    {
        void Inserir(PedidoIngrediente PedidoIngrediente);
        void Atualizar(PedidoIngrediente PedidoIngrediente);
        void Excluir(Guid id);
        PedidoIngrediente BuscarPorId(Guid id);
        List<PedidoIngrediente> BuscarTodos();
    }
}
