using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Comum;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorHoristaRepositorio
    {
        private List<ProfessorHorista> _professoresHorista = new List<ProfessorHorista>();


        public ProfessorHoristaRepositorio()
        {
            _professoresHorista = DatabaseArquivoHelper.LerArquivo<ProfessorHorista>("ProfessorHorista");
        }
        public void Inserir(ProfessorHorista professorHorista)
        {
            professorHorista.GerarId();
            _professoresHorista.Add(professorHorista);
           GravarProfessorHoristaArquivo(_professoresHorista);
        }

        public List<ProfessorHorista> BuscarTodos()
        {
            return _professoresHorista;
        }

        public ProfessorHorista BuscarPorId(Guid id)
        {
            return _professoresHorista.FirstOrDefault(p => p.Id == id);
        }

        public void Atualizar(ProfessorHorista professorHorista)
        {
            var professorHoristaLista = _professoresHorista.FirstOrDefault(p => p.Id == professorHorista.Id);
            professorHoristaLista = professorHorista;
            GravarProfessorHoristaArquivo(_professoresHorista);
        }

        public void Excluir(Guid id)
        {
            _professoresHorista = _professoresHorista.Where(p => p.Id != id).ToList();

        }

        private void GravarProfessorHoristaArquivo(List<ProfessorHorista> professoresHorista)
        {
            var conteudo = JsonConvert.SerializeObject(professoresHorista);
            DatabaseArquivoHelper.GravaArquivo(conteudo, "ProfessorHorista");
        }
    }
}
