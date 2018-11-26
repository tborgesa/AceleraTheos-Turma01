using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public abstract class Escolaridade
    {
        protected Escolaridade(string propEscolaridade, decimal salario)
        {
            PropEscolaridade = propEscolaridade;
            Salario = salario;
        }

        public string PropEscolaridade { get; }
        public decimal Salario { get; }

        public virtual decimal GetSalario()
        {
            return Salario;
        }
    }
}
