using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Ingrediente.Interfaces
{
    public interface IIngredienteService
    {
        IngredienteDtoReturn Inserir(IngredienteInserirViewModel clienteViewModel);
        IngredienteDto BuscarPorId(Guid id);
        IngredienteDtoReturn Atualizar(IngredienteAtualizarViewModel clienteAtualizarViewModel);
        string Excluir(Guid id);
    }
}
