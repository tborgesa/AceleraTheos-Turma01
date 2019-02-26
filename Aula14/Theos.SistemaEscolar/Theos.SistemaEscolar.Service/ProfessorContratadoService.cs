using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Interfaces;
using Theos.SistemaEscolar.Dominio.Professor;
using Theos.SistemaEscolar.Repositorio;

namespace Theos.SistemaEscolar.Service
{
    public class ProfessorContratadoService
    {
        public IProfessorContratadoRepositorio _repositorio;

        public ProfessorContratadoService()
        {
            var tipoDataBase = int.Parse(ConfigurationManager.AppSettings["TipoDataBase"]);

            switch (tipoDataBase)
            {
                case 1:
                    _repositorio = new ProfessorContratadoDapperRepositorio();
                    break;
                case 2:
                    _repositorio = new ProfessorContratadoAdoNetRepositorio();
                    break;
                case 3:
                    _repositorio = new ProfessorContratadoRepositorio();
                    break;
                default:
                    throw new Exception("Tipo de repositório não configurado");
            }
        }

        public ProfessorContratadoDtoReturn Inserir(ProfessorContratadoInserirViewModel professorContratadoViewModel)
        {
            var professorContratado = new ProfessorContratado(professorContratadoViewModel.Nome, professorContratadoViewModel.Cpf
                , professorContratadoViewModel.Escolaridade);

            if (!professorContratado.Valido())
                return new ProfessorContratadoDtoReturn(professorContratado.GetErros());

            professorContratado.GerarId();
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
            professorContratado.Alterar(professorContratadoAtualizarViewModel.Nome, professorContratadoAtualizarViewModel.Cpf, 
                professorContratadoAtualizarViewModel.Escolaridade);
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
