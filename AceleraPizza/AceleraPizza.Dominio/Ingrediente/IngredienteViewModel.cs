using System;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class IngredienteViewModel
    {
        public IngredienteViewModel(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
