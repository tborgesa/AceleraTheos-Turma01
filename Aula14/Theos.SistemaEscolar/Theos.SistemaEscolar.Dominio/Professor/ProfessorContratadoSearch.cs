using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Enumerador;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorContratadoSearch
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public EEscolaridade Escolaridade { get; set; }
    }
}
