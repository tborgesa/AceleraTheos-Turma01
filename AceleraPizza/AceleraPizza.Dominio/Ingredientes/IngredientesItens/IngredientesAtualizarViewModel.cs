using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Ingredientes.IngredientesItens
{
    public interface IIngredientesRepositorio
    {
        void Inserir(Ingredientes ingrediente);
        void Atualizar(Ingredientes ingrediente);
    }
}