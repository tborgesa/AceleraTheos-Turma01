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
        private ContratadoRepositorio _repositorio = new ContratadoRepositorio();

        public  ContratadoDto Inserir(ContratadoInserirViewModel contratadoViewModel)
        {
            var contratado = new Contratado(contratadoViewModel.DataNascimento, contratadoViewModel.Cpf, contratadoViewModel.Nome
                    , contratadoViewModel.Endereco, contratadoViewModel.Escolaridade);

            _repositorio.Inserir(contratado);

            return BuscarPorId(contratado.Id);
        }

        public ContratadoDto BuscarPorId(Guid id)
        {
            Contratado contratado = _repositorio.BuscarPorId(id);

            return new ContratadoDto
            {
                Id = contratado.Id,
                Cpf = contratado.Cpf,
                DataInsercao = contratado.DataInsercao,
                DataNascimento = contratado.DataNascimento,
                Endereco = contratado.Endereco,
                Nome = contratado.Nome,
                Escolaridade = contratado.Escolaridade
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

        public ContratadoDto Atualizar(ContratadoAtualizarViewModel contratadoAtualizarViewModel)
        {
            var contratado = _repositorio.BuscarPorId(contratadoAtualizarViewModel.Id);
            contratado.AlterarEndereco(contratadoAtualizarViewModel.Endereco);
            contratado.SetarAlteracao();

            _repositorio.Atualizar(contratado);

            return BuscarPorId(contratadoAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}