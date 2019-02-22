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
    public class ProfessorContratadoRepositorio
    {
        private List<ProfessorContratado> _professorContratado = new List<ProfessorContratado>();

        public ProfessorContratadoRepositorio()
        {
            _professorContratado = DatabaseArquivoHelper.LerArquivo<ProfessorContratado>("ProfessorContratado");
        }

        public void Inserir(ProfessorContratado professorContratado)
        {
            professorContratado.GerarId();
            _professorContratado.Add(professorContratado);
            GravarProfessorContratadoArquivo(_professorContratado);
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
            professorContratadoLista = professorContratado;
            GravarProfessorContratadoArquivo(_professorContratado);
        }

        public void Excluir(Guid id)
        {
            _professorContratado = _professorContratado.Where(p => p.Id != id).ToList();
            GravarProfessorContratadoArquivo(_professorContratado);
        }

        public void GravarProfessorContratadoArquivo(List<ProfessorContratado> professoresContratados)
        {
            var conteudo = JsonConvert.SerializeObject(professoresContratados);
            DatabaseArquivoHelper.GravaArquivo(conteudo, "ProfessorContratado");
        }

    }
}
