using System;
using System.Collections.Generic;
using SistemaEscola.Dominio.Contratado;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Dominio;
using SistemaEscola.Dominio.Funcionario.Interfaces;
using SistemaEscola.Dominio.Contratado.Interfacecs;

namespace SistemaEscola.Service
{
    public class ContratadoService : IContratadoService
    {
        private IContratadoRepositorio _repositorio;

        public ContratadoService(IContratadoRepositorio repositorio)
        {
            _repositorio = repositorio;
            //var tipoBancoDados = int.Parse(ConfigurationManager.AppSettings["TipoBancoDados"]);

            //switch (tipoBancoDados)
            //{
            //    case 1:
            //        _repositorio = new ContratadoArquivoRepositorio();
            //        break;
            //    case 2:
            //        _repositorio = new ContratadoAdoNetRepositorio();
            //        break;
            //    case 3:
            //        _repositorio = new ContratadoDapperRepositorio();
            //        break;
            //    default:
            //        _repositorio = new ContratadoArquivoRepositorio();
            //        break;
            //}
        }

        public ContratadoDtoReturn Inserir(ContratadoInserirViewModel contratadoViewModel)
        {
            var contratado = new Contratado(
                contratadoViewModel.Nome,
                contratadoViewModel.Cpf,
                contratadoViewModel.DataNascimento,
                contratadoViewModel.Endereco,
                contratadoViewModel.Escolaridade
                );

            if (!contratado.Valido())
                return new ContratadoDtoReturn(contratado.GetErros());

            contratado.GerarId();
            _repositorio.Inserir(contratado);

            return new ContratadoDtoReturn(BuscarPorId(contratado.Id));
        }

        public ContratadoDto BuscarPorId(Guid id)
        {
            Contratado contratado = _repositorio.BuscarPorId(id);

            if (contratado == null)
                return null;

            return new ContratadoDto
            {
                Id = contratado.Id,
                Cpf = contratado.Cpf,
                DataInsercao = contratado.DataInsercao,
                DataNascimento = contratado.DataNascimento,
                Endereco = contratado.Endereco,
                Nome = contratado.Nome,
                Escolaridade = contratado.GetEEscolaridade()
            };
        }

        public List<FuncionarioSearch> BuscarTodos()
        {
            List<Contratado> contratadoes = _repositorio.BuscarTodos();

            List<FuncionarioSearch> retorno = new List<FuncionarioSearch>();

            foreach (var contratado in contratadoes)
            {
                retorno.Add(new FuncionarioSearch
                {
                    Id = contratado.Id,
                    Cpf = contratado.Cpf,
                    Nome = contratado.Nome,
                });
            }

            return retorno;
        }

        public ContratadoDtoReturn Atualizar(ContratadoAtualizarViewModel contratadoAtualizarViewModel)
        {
            var contratado = _repositorio.BuscarPorId(contratadoAtualizarViewModel.Id);

            if (contratado == null)
            {
                var erros = new List<string>();
                erros.Add("Contratado não existe.");
                return new ContratadoDtoReturn(erros);
            }

            contratado.AlterarEndereco(contratadoAtualizarViewModel.Endereco);
            contratado.AlterarEscolaridade(contratadoAtualizarViewModel.Escolaridade);
            contratado.SetarAlteracao();

            if (!contratado.Valido())
                return new ContratadoDtoReturn(contratado.GetErros());

            _repositorio.Atualizar(contratado);

            return new ContratadoDtoReturn(BuscarPorId(contratado.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}