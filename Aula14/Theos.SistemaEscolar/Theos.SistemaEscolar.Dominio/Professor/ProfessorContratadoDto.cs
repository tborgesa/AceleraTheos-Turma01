using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Enumerador;

namespace Theos.SistemaEscolar.Dominio.Professor
{
   public class ProfessorContratadoDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public EEscolaridade Escolaridade { get; set; }
    }

    public class ProfessorContratadoDtoReturn
    {
        public ProfessorContratadoDto ProfessorContratado { get; }
        public List<string> Erros { get; }

        public ProfessorContratadoDtoReturn(ProfessorContratadoDto professorContratado)
        {
            ProfessorContratado = professorContratado;
            Erros = new List<string>();
        }

        public ProfessorContratadoDtoReturn(List<string> erros)
        {
            ProfessorContratado = new ProfessorContratadoDto();
            Erros = erros;
        }
    }
}
