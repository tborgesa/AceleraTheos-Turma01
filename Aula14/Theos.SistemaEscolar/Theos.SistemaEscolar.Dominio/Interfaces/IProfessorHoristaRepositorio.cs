using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Dominio.Interfaces
{
    public interface IProfessorHoristaRepositorio
    {
        void Inserir(ProfessorHorista professorHorista);
        void Atualizar(ProfessorHorista professorHorista);
        void Excluir(Guid id);
        ProfessorHorista BuscarPorId(Guid id);
        List<ProfessorHorista> BuscarTodos();
    }
}
