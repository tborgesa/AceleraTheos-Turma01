using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class EnsinoSuperior : Escolaridade
    {
        public EnsinoSuperior(double salario) : base(salario)
        {

        }

        public virtual double GetSalario()
        {
            double salario = 1800;
            return salario;
        }
    }
}
