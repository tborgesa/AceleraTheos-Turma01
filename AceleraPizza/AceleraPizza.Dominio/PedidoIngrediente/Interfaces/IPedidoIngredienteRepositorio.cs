using System;

namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteRepositorio
    {
        void Inserir(_PedidoIngrediente PedidoIngrediente);
        void Atualizar(_PedidoIngrediente PedidoIngrediente);
        void Excluir(Guid id);
        _PedidoIngrediente BuscarPorId(Guid id);
    }
}
