using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class Doutorado : Escolaridade
    {
        public Doutorado(double salario): base (salario)
        {

        }

        public virtual double GetSalario()
        {
            double salario = 5000;
            return salario;
        }
    }
}
