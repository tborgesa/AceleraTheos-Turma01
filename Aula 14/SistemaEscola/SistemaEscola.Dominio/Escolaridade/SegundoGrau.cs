using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class SegundoGrau : Escolaridade
    {
        public SegundoGrau(double salario) : base (salario)
        {

        }

        public virtual double GetSalario()
        {
            double salario = 1000;
            return salario;
        }
    }
}
