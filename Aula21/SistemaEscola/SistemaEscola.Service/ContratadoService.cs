using System;
using System.Collections.Generic;
using SistemaEscola.Dominio.Contratado;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Dominio;
using SistemaEscola.Repositorio;


namespace SistemaEscola.Service
{
    public class ContratadoService
    {
        private ContratadoArquivoRepositorio _repositorio = new ContratadoArquivoRepositorio();

        public ContratadoDtoReturn Inserir(ContratadoInserirViewModel contratadoViewModel)
        {
            var contratado = new Contratado(
                contratadoViewModel.DataNascimento,
                contratadoViewModel.Nome,
                contratadoViewModel.Cpf,
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