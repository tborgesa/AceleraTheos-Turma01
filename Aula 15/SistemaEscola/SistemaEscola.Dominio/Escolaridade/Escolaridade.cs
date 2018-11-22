using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class Escolaridade
    {
        public Escolaridade(double salario)
        {
            Salario = salario;
        }

        public double Salario { get; }

        public virtual double GetSalario()
        {
            double salario = 0;
            return salario;
        }
    }
}
