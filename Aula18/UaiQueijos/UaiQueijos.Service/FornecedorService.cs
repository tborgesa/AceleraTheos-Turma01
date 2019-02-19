using System;
using System.Collections.Generic;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Repositorio;

namespace UaiQueijos.Service
{
    public class FornecedorService
    {
        private FornecedorDapperRepositorio _repositorio = new FornecedorDapperRepositorio();

        public FornecedorDtoReturn Inserir(FornecedorInserirViewModel fornecedorViewModel)
        {
            var fornecedor = new Fornecedor(fornecedorViewModel.DataNascimento, fornecedorViewModel.Cpf, fornecedorViewModel.Nome
                    , fornecedorViewModel.Endereco, fornecedorViewModel.NomeFantasia);

            if (!fornecedor.Valido())
                return new FornecedorDtoReturn(fornecedor.GetErros());

            fornecedor.GerarId();
            _repositorio.Inserir(fornecedor);
            return new FornecedorDtoReturn(BuscarPorId(fornecedor.Id));
        }

        public FornecedorDto BuscarPorId(Guid id)
        {
            Fornecedor fornecedor = _repositorio.BuscarPorId(id);

            fornecedor = _repositorio.BuscarPorCpf(fornecedor.Cpf);

            if (fornecedor == null)
                return null;

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

        public List<FornecedorSearchDto> BuscarTodos()
        {
            List<Fornecedor> fornecedores = _repositorio.BuscarTodos();

            List<FornecedorSearchDto> retorno = new List<FornecedorSearchDto>();

            foreach (var fornecedor in fornecedores)
            {
                retorno.Add(new FornecedorSearchDto
                {
                    Id = fornecedor.Id,
                    Cpf = fornecedor.Cpf,
                    Nome = fornecedor.Nome,
                });
            }

            return retorno;
        }

        public FornecedorDtoReturn Atualizar(FornecedorAtualizarViewModel fornecedorAtualizarViewModel)
        {
            var fornecedor = _repositorio.BuscarPorId(fornecedorAtualizarViewModel.Id);
                       
            if (fornecedor == null)
            {
                var erros = new List<string>();
                erros.Add("Fornecedor não existe.");
                return new FornecedorDtoReturn(erros);
            }

            fornecedor.AlterarEndereco(fornecedorAtualizarViewModel.Endereco);
            fornecedor.SetarAlteracao();

            if (!fornecedor.Valido())
                return new FornecedorDtoReturn(fornecedor.GetErros());

            _repositorio.Atualizar(fornecedor);

            return new FornecedorDtoReturn(BuscarPorId(fornecedor.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}
