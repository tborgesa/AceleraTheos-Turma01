using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;


namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorContratadoRepositorio
    {
        private List<ProfessorContratado> _professorContratado = new List<ProfessorContratado>();

        public void Inserir(ProfessorContratado professorContratado)
        {
            professorContratado.GerarId();
            _professorContratado.Add(professorContratado);
        }

        public ProfessorContratado BuscarPorId(Guid id)
        {
            return _professorContratado.FirstOrDefault(p => p.Id == id);
        }

        public List<ProfessorContratado> BuscarTodos()
        {
            return _professorContratado;
        }

        public void Atualizar(ProfessorContratado professorContratado)
        {
            var professorContratadoLista = _professorContratado.FirstOrDefault(p => p.Id == professorContratado.Id);
        }

        public void Excluir(Guid id)
        {
            _professorContratado = _professorContratado.Where(p => p.Id != id).ToList();            
        }

    }
}
