using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Ingredientes
{
    public abstract class Ingredientes
    {
        protected Ingredientes(string ingredientesDescricao, double valor)
        {
            this.erro = erro;
            IngredientesDescricao = ingredientesDescricao;
            Valor = valor;
        }

        public virtual double GetValorIngredientes()
        {
            var total = 2;
            return total;
        }

        public string erro { get; private set; }
        public string IngredientesDescricao { get; private set; }
        public double Valor { get; }
    }
}
