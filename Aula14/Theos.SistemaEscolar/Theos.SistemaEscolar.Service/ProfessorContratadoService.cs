using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;
using Theos.SistemaEscolar.Repositorio;

namespace Theos.SistemaEscolar.Service
{
    public class ProfessorContratadoService
    {
        private ProfessorContratadoRepositorio _repositorio = new ProfessorContratadoRepositorio();

        public ProfessorContratadoDtoReturn Inserir(ProfessorContratadoInserirViewModel professorContratadoViewModel)
        {
            var professorContratado = new ProfessorContratado(professorContratadoViewModel.Nome, professorContratadoViewModel.Cpf
                , professorContratadoViewModel.Escolaridade);

            if (!professorContratado.Valido())
                return new ProfessorContratadoDtoReturn(professorContratado.GetErros());

            _repositorio.Inserir(professorContratado);
            return new ProfessorContratadoDtoReturn(BuscarPorId(professorContratado.Id));


        }

        public ProfessorContratadoDto BuscarPorId(Guid id)
        {
            ProfessorContratado professorContratado = _repositorio.BuscarPorId(id);

            if (professorContratado == null)
            {
                return null;
            }

            return new ProfessorContratadoDto
            {
                Id = professorContratado.Id,
                Cpf = professorContratado.Cpf,
                Nome = professorContratado.Nome,
                Escolaridade = professorContratado.Escolaridade,
                DataInsercao = professorContratado.DataInsercao
            };
        }

        public List<ProfessorContratadoSearch> BuscarTodos()
        {
            List<ProfessorContratado> professoresContratados = _repositorio.BuscarTodos();

            List<ProfessorContratadoSearch> retorno = new List<ProfessorContratadoSearch>();

            foreach (var professorContratado in professoresContratados)
            {
                retorno.Add(new ProfessorContratadoSearch
                {
                    Id = professorContratado.Id,
                    Cpf = professorContratado.Cpf,
                    Nome = professorContratado.Nome,
                    Escolaridade = professorContratado.Escolaridade,
                });
            }

            return retorno;
        }

        public ProfessorContratadoDto Atualizar(ProfessorContratadoAtualizarViewModel professorContratadoAtualizarViewModel)
        {
            var professorContratado = _repositorio.BuscarPorId(professorContratadoAtualizarViewModel.Id);
            professorContratado.Alterar(professorContratadoAtualizarViewModel.Nome, professorContratadoAtualizarViewModel.Cpf);
            professorContratado.SetarAlteracao();

            _repositorio.Atualizar(professorContratado);

            return BuscarPorId(professorContratadoAtualizarViewModel.Id);

        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}
