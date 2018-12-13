using System;
using System.Collections.Generic;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Repositorio;

namespace UaiQueijos.Service
{
    public class FornecedorService
    {
        private FornecedorRepositorio _repositorio = new FornecedorRepositorio();

        public FornecedorDto Inserir (FornecedorInserirViewModel fornecedorViewModel)
        {
            var fornecedor = new Fornecedor(fornecedorViewModel.DataNascimento, fornecedorViewModel.Cpf, fornecedorViewModel.Nome
                    , fornecedorViewModel.Endereco, fornecedorViewModel.NomeFantasia);

            _repositorio.Inserir(fornecedor);

            return BuscarPorId(fornecedor.Id);
        }

        public FornecedorDto BuscarPorId(Guid id)
        {
            Fornecedor fornecedor = _repositorio.BuscarPorId(id);

            return new FornecedorDto
            {
                Id = fornecedor.Id,
                Cpf = fornecedor.Cpf,
                DataInsercao = fornecedor.DataInsercao,
                DataNascimento = fornecedor.DataNascimento,
                Endereco = fornecedor.Endereco,
                Nome = fornecedor.Nome,
                NomeFantasia = fornecedor.NomeFantasia
            };
        }

        public List<FornecedorSearch> BuscarTodos()
        {
            List<Fornecedor> fornecedores = _repositorio.BuscarTodos();

            List<FornecedorSearch> retorno = new List<FornecedorSearch>();

            foreach (var fornecedor in fornecedores)
            {
                retorno.Add(new FornecedorSearch
                {
                    Id = fornecedor.Id,
                    Cpf = fornecedor.Cpf,
                    Nome = fornecedor.Nome,
                });
            }

            return retorno;
        }

        public FornecedorDto Atualizar(FornecedorAtualizarViewModel fornecedorAtualizarViewModel)
        {
            var fornecedor = _repositorio.BuscarPorId(fornecedorAtualizarViewModel.Id);
            fornecedor.AlterarEndereco(fornecedorAtualizarViewModel.Endereco);
            fornecedor.SetarAlteracao();

            _repositorio.Atualizar(fornecedor);

            return BuscarPorId(fornecedorAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}
