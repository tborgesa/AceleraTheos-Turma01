using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class IngredienteDto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }

    public class IngredienteDtoReturn
    {
        public IngredienteDtoReturn(IngredienteDto ingrediente)
        {
            Ingrediente = ingrediente;
            Erros = new List<string>();
        }

        public IngredienteDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public IngredienteDto Ingrediente { get; }
        public List<string> Erros { get; }
    }
}

