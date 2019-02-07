using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorHoristaDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int HorasTrabalhadas { get; set; }
    }

    public class ProfessorHoristaDtoReturn
    {
        public ProfessorHoristaDto ProfessorHorista { get; }
        public List<string> Erros { get; }

        public ProfessorHoristaDtoReturn(ProfessorHoristaDto professorHorista)
        {
            ProfessorHorista = professorHorista;
            Erros = new List<string>();
        }

        public ProfessorHoristaDtoReturn(List<string> erros)
        {
            ProfessorHorista = new ProfessorHoristaDto();
            Erros = erros;
        }
    }


}
