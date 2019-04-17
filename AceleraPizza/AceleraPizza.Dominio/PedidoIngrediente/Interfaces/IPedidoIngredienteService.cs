using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteService
    {
        PedidoIngredienteDtoReturn Inserir(PedidoIngredienteInserirViewModel PedidoIngredienteViewModel);
        PedidoIngredienteDto BuscarPorId(Guid id);
        List<PedidoIngredienteSearch> BuscarTodos();
        PedidoIngredienteDtoReturn Atualizar(PedidoIngredienteAtualizarViewModel PedidoIngredienteAtualizarViewModel);
        void Excluir(Guid id);
    }
}
