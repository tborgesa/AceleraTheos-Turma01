using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Dominio.Professor
{
   public class ProfessorHoristaAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public int HorasTrabalhadas { get; set; } = 0;
    }
}
