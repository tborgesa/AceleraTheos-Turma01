using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
   public class ProfessorHoristaRepositorio
    {
        private List<ProfessorHorista> _professorHorista = new List<ProfessorHorista>();

        public void Inserir(ProfessorHorista professorHorista)
        {
             professorHorista.GerarId();
            _professorHorista.Add(professorHorista);
        }

        public List<ProfessorHorista> BuscarTodos()
        {
            return _professorHorista;
        }

        public ProfessorHorista BuscarPorId(Guid id)
        {
            return _professorHorista.FirstOrDefault(p => p.Id == id);
        }

        public void Atualizar(ProfessorHorista professorHorista)
        {
            var professorHoristaLista = _professorHorista.FirstOrDefault(p => p.Id == professorHorista.Id);
        }

        public void Excluir(Guid id)
        {
            _professorHorista = _professorHorista.Where(p => p.Id != id).ToList();
        }
    }
}
