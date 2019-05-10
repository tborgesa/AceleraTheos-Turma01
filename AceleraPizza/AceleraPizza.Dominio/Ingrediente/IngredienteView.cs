using System;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class IngredienteView
    {
        public IngredienteView(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
