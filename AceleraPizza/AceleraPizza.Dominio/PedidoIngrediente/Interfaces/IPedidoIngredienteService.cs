using System;
using System.Collections.Generic;


namespace AceleraPizza.Dominio.PedidoIngrediente.Interfaces
{
    public interface IPedidoIngredienteService
    {
        PedidoIngredienteDtoReturn Inserir(PedidoIngredienteInserirViewModel PedidoIngredienteViewModel);
        PedidoIngredienteDto BuscarPorId(Guid id);
        List<PedidoIngredienteSearch.PedidoIngredienteSearch> BuscarTodos(Guid id);
        void Excluir(Guid id);
    }
}
