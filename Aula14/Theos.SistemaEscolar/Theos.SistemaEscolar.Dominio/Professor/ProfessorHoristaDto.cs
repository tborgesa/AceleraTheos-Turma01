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
        public string Cpf{ get; set; }
        public int HorasTrabalhadas { get; set; }
    }
}
