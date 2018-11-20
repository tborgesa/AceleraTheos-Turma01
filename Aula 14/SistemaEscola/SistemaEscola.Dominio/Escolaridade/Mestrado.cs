using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class Mestrado : Escolaridade
    {
        public Mestrado(double salario) : base(salario)
        {

        }

        public virtual double GetSalario()
        {
            double salario = 3000;
            return salario;
        }
    }
}
