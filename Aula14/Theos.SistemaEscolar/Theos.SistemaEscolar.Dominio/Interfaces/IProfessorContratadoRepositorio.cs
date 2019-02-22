using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Dominio.Interfaces
{
    public interface IProfessorContratadoRepositorio
    {
        void Inserir(ProfessorContratado professorContratado);
        void Atualizar(ProfessorContratado professorContratado);
        void Excluir(Guid id);
        ProfessorContratado BuscarPorId(Guid id);
        List<ProfessorContratado> BuscarTodos();
    }
}
