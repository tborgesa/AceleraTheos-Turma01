using System;
using System.Collections.Generic;


namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteService
    {
        PedidoIngredienteDtoReturn Inserir(PedidoIngredienteInserirViewModel PedidoIngredienteViewModel);
        //PedidoIngredienteDto BuscarPorId(Guid id);
        //PedidoIngredienteDtoReturn Atualizar(PedidoIngredienteAtualizarViewModel PedidoIngredienteAtualizarViewModel);
        List<PedidoIngredienteSearch.PedidoIngredienteSearch> BuscarTodos();
        void Excluir(Guid id);
    }
}
