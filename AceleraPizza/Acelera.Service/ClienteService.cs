using System;
using System.Collections.Generic;
using AceleraPizza.Dominio;

namespace AceleraPizza.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepositorio _repositorio;

        public ClienteService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(
                clienteViewModel.Nome,
                clienteViewModel.Cpf,
                clienteViewModel.DataNascimento,
                clienteViewModel.Endereco,
                );

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            cliente.GerarId();
            _repositorio.Inserir(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            Cliente cliente = _repositorio.BuscarPorId(id);

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Cpf = cliente.Cpf,
                DataInsercao = cliente.DataInsercao,
                DataNascimento = cliente.DataNascimento,
                Endereco = cliente.Endereco,
                Nome = cliente.Nome,
            };
        }

        public List<FuncionarioSearch> BuscarTodos()
        {
            List<Cliente> clientees = _repositorio.BuscarTodos();

            List<FuncionarioSearch> retorno = new List<FuncionarioSearch>();

            foreach (var cliente in clientees)
            {
                retorno.Add(new FuncionarioSearch
                {
                    Id = cliente.Id,
                    Cpf = cliente.Cpf,
                    Nome = cliente.Nome,
                });
            }

            return retorno;
        }

        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repositorio.BuscarPorId(clienteAtualizarViewModel.Id);

            if (cliente == null)
            {
                var erros = new List<string>();
                erros.Add("Cliente não existe.");
                return new ClienteDtoReturn(erros);
            }

            cliente.AlterarEndereco(clienteAtualizarViewModel.Endereco);
            cliente.AlterarEscolaridade(clienteAtualizarViewModel.Escolaridade);
            cliente.SetarAlteracao();

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repositorio.Atualizar(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}